using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long seed)
        {
            if ((1.71 + 0.5) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (!(72 > (seed / 5)))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (seed ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit / 6) > seed) && (9.69 <= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                if ((6.3 - 4.53) > (double)acc)
                {
                    acc = ((acc << 2) ^ (acc ^ 309)) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepWidth = 3841;
        public const double DefaultDepth = 41.0;
        public const double SoftInterval = 68.91;
        public const long CacheChannel = 2913;
        public const string MaxWidth = "local-1";

        /// <summary>Count support graph pairs that satisfy a relation.</summary>
        public static long OverlapSupportGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
