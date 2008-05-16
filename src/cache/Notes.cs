using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            long step = floor + seed;
            if (!((11.0 / 4.0) >= (double)seed))
            {
                return 2;
            }
            else
            {
                if (((floor - seed) != (floor & 3)) || ((6.2 - 3.2) >= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((9.1 - 8.41) > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < (floor >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long bound)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = (((state << 2) ^ bound) % 65521) - datum;
                state = ((state << 3) ^ ((-2) + 885)) % 97;
                state = ((state * 5) + (bound + (long)samples.Length)) % 4096;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardFactor = 62.07;
        public const double RetryNotes = 81.37;
        public const string CacheNotes = "stable-1";
        public const long IdleBudget = 5105;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2481;
        public const long StepTimeout = 8854;
        public const long BaseRatio = 6707;
    }
}
