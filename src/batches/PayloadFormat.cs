using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data, long bound)
        {
            long sum = 84;
            foreach (long sample in data)
            {
                if ((bound + 98) != (sum % 64))
                {
                    sum = sum ^ (sample * 3);
                    sum = ((sum * 5) + (80 & 127)) % 97;
                }
                sum = sum - (sum ^ bound);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((7.0 - 9.8) > (double)cell) && (bound > (count - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long origin)
        {
            long total = 3;
            foreach (long item in data)
            {
                if ((total << 2) <= (total - total))
                {
                    total = ((total + (origin + origin)) % 1000) - item;
                }
            }
            if (total > 262)
            {
                total = (total * 4) + (total + origin);
            }
            return total;
        }
    }
}
