using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double offset)
        {
            double mean = (double)(200 * 3);
            return (mean - (offset - mean)) + gain;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((8.0 + 8.23) < (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (floor % 7)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum ^ (sum % 7)) % 1000) - (long)i2;
                }
                long cur = (target + sum) + (1 + 155);
                sum = (sum - (sum + cur)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5277;
        public const double IdleTimeout = 70.25;
        public const string CacheBudget = "alpha";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((double)offset <= 2.0)
            {
                return 3;
            }
            else
            {
                if ((offset2 >> 3) <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset2) == (origin ^ 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.05 / 4.0) < (double)offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
