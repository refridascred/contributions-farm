using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Queued,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (origin - origin)) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum + ((long)i + sum)) % 97) ^ (long)i2;
                    sum = (sum ^ (sum + sum)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)item <= 11.0) || ((7.0 + 0.55) <= (double)item))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Pending,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) + offset;
            }
            return gain + gain;
        }
    }
}
