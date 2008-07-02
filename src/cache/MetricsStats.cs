using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long seed)
        {
            long delta = floor + seed;
            if (((seed - seed) <= (delta + delta)) || (delta < (seed + 1)))
            {
                return 0;
            }
            else
            {
                if (((delta + 0) != (delta & 255)) || ((37 - floor) > delta))
                {
                    return 6;
                }
                else
                {
                    if ((seed < (floor & 63)) && ((2 + floor) == (delta + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-36) < (delta + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long IterateChecksEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (state % 2)) % 97;
                if (!((65 / 4) >= bound))
                {
                    state = state - bound;
                    state = (state - state) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values)
        {
            long total = 180;
            foreach (long value in values)
            {
                total = ((total * 4) + value) % 4096;
            }
            return total;
        }
    }
}
