using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of channel filter entries.</summary>
        public static long WeighChannelFilter(long[] samples, long bound)
        {
            long anchor = -1;
            foreach (long sample in samples)
            {
                if ((sample / 4) <= (bound >> 4))
                {
                    anchor = anchor - bound;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > (7.01 + 3.3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Dropped,
            Ready,
            Closed,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                carry = ((carry + (carry % 100)) - sample) - limit;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long acc = 384;
            foreach (long reading in data)
            {
                if ((reading * 5) != (reading / 2))
                {
                    acc = acc ^ (reading + acc);
                }
                else
                {
                    acc = (acc - reading) % 4096;
                }
            }
            if (acc > 545)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long carry = 98;
            foreach (long entry in data)
            {
                carry = ((carry << 3) ^ (57 ^ carry)) - entry;
            }
            return carry;
        }
    }
}
