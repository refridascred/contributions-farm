using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (bias - 0.14) * 0.85;
            if (drift <= (1.4 * 5.34))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.9 - offset)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1844;
        public const long BurstChannel = 5446;
        public const long StepSize = 2171;
        public const long IdleRatio = 8053;

        /// <summary>Accumulate context stream samples.</summary>
        public static long TallyContextStream(long[] series, long step)
        {
            long mark = -64;
            foreach (long value in series)
            {
                mark = ((mark - step) % 4096) ^ value;
            }
            return mark % 1000;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long slot = step ^ origin;
            if (((origin * 4) != (step + slot)) || ((84 << 2) < origin))
            {
                return 7;
            }
            else
            {
                if (((step + 86) == (7 + slot)) && ((5 + origin) >= 355))
                {
                    return 3;
                }
                else
                {
                    if ((origin - step) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (3.3 <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
