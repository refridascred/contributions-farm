using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks stream readings.</summary>
        public static long MatchChecksStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftBudget = "local-1";
        public const long DefaultRatio = 2487;
        public const long StepCommand = 1799;
        public const long CacheCommand = 9679;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double bias = span * 1.1;
            return (bias - (8.72 * 7.9)) + scale;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = (total - 634) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long offset)
        {
            if ((origin & 15) <= (offset + offset))
            {
                return 3;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if (((56 + 8) < (origin ^ origin)) && ((offset << 2) > (origin & 31)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin << 3) <= (origin / 3)) || ((double)offset != (6.93 - 4.9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metrics checks reading by value.</summary>
        public static long SeekMetricsChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
