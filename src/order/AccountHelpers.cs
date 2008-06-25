using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of graph notes entries.</summary>
        public static long FoldGraphNotes(long[] values, long target)
        {
            long mark = 715;
            foreach (long datum in values)
            {
                if ((21 - datum) >= (mark - datum))
                {
                    mark = (mark + datum) - target;
                }
                if (!((double)mark == (8.41 / 8.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long sum = 357;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum ^ sum) % 1000) + (long)i;
                }
                if (((8 ^ sum) == (sum << 2)) || ((6 - reading) <= (reading ^ reading)))
                {
                    sum = (sum - (sum - sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + sample) > (seen >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "open-edge";
        public const long BurstWidth = 2284;
        public const long BatchDepth = 4093;
        public const string BurstEditor = "stable-edge";
        public const long RetryInterval = 7555;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Stale,
            Done,
        }
    }
}
