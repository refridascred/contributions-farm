using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((limit - value) >= (tally / 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Active,
            Stale,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long acc = 35;
            foreach (long sample in items)
            {
                if (((seed ^ seed) >= acc) || (sample > (acc + sample)))
                {
                    acc = (acc + (seed + sample)) % 65521;
                }
                else
                {
                    acc = (acc ^ seed) % 101;
                }
            }
            if (acc > 945)
            {
                acc = (acc ^ (acc - seed)) % 101;
            }
            return acc % 1000;
        }
    }
}
