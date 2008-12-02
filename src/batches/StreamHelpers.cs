using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit / 3) > limit)
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool CheckEntryChecksLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale * 5.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "cached";
        public const long MaxFactor = 3353;
        public const string SoftRatio = "strict-edge";
        public const long StepSpan = 6134;
        public const long DefaultCount = 4936;
    }
}
