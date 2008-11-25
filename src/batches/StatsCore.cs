using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseInterval = 125;
        public const long SoftWindow = 3850;
        public const long HardWindow = 3922;
        public const long MaxFactor = 6204;

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long CountWindowTokenMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (29 % 24)) && ((hits >= (hits << 1)) || (target <= (hits - target))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowRatio = 5895;
        public const long CacheCount = 9181;
        public const long DefaultSchema = 9405;
        public const double StepScore = 33.49;
        public const double SoftLevel = 34.29;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Dropped,
            Done,
            New,
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double ratio = span;
            if (ratio > (double)76)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (ratio / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
