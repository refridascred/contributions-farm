using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a checks context figure with a bias.</summary>
        public static double BlendChecksContext(double weight, double offset)
        {
            double bias = weight * 2.3;
            if (bias > (offset - 9.98))
            {
                bias = bias + (weight - offset);
            }
            else
            {
                bias = bias - (bias / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) <= (hits % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 3951;
        public const string BurstFarm = "primary";
        public const double BaseScore = 94.06;
        public const double MinWidth = 58.31;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long origin)
        {
            long bound = step + origin;
            if (bound >= origin)
            {
                return 6;
            }
            else
            {
                if ((origin + step) == (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (9.5 + 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound > (origin >> 4)))
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

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
