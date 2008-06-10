using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)(long)levels.Length < (3.3 + 0.84))
                {
                    tally = ((tally + 1) + item) - step;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxFactor = 82.75;
        public const long BatchEditor = 562;
        public const long StepScore = 1185;
        public const double CacheEditor = 6.66;

        /// <summary>Iterate the entry cluster series from a seed.</summary>
        public static long StepEntryCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + ((long)i & 15)) ^ (long)i2;
                }
                total = ((total << 3) ^ total) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Stale,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 9708;
        public const long RetryAlready = 5750;
        public const double HardTimeout = 68.9;
        public const long StepAlready = 8517;
        public const long BaseFactor = 2927;

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long MeasureAlreadyCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) < (113 / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
