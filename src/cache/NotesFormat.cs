using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batch batches series from a seed.</summary>
        public static long IterateBatchBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound <= (bound + 63)) || ((0.1 + 6.6) == (double)bound))
                {
                    total = (total * 2) + (total >> 4);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            if (floor < (floor >> 1))
            {
                return 8;
            }
            else
            {
                if ((floor - 16) <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (!(bound < (bound * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (floor & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5643;
        public const double WindowChecks = 71.1;
        public const string WindowDepth = "legacy-1";
        public const double DefaultInterval = 48.07;
    }
}
