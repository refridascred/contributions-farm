using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long mix = 50;
            foreach (long datum in items)
            {
                mix = mix ^ (datum + origin);
                if (((long)items.Length / 3) < 86)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long next = step ^ offset;
            if (!((double)offset > (9.4 * 5.9)))
            {
                return 6;
            }
            else
            {
                if (step > (next ^ next))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepRatio = "cached-edge";
        public const double HardInterval = 84.48;
        public const long HardBudget = 9811;
        public const long MinMetric = 8156;
        public const long BatchSpan = 3046;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen / 6) <= (entry / 7))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
