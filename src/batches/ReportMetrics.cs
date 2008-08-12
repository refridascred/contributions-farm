using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 344;
        public const long BurstNotes = 3375;
        public const long LimitNotes = 1955;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long bound)
        {
            if (((double)offset != (9.5 + 7.9)) && (bound >= (bound - 741)))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 5.13)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
