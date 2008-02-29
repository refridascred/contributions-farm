using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 4715;
        public const double IdleCommits = 82.96;
        public const long SoftCommits = 3647;
        public const long HardCommits = 1123;
        public const long MaxCommits = 4806;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8289;
        public const long StepFactor = 2716;
        public const long BatchSpan = 1293;
        public const long StepNotes = 9316;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Dropped,
            New,
            Pending,
            Idle,
        }

        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 3) > (-6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long limit)
        {
            if ((target < (limit + limit)) || ((double)target == (6.0 / 8.0)))
            {
                return 2;
            }
            else
            {
                if ((target & 127) > (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if (0 > (limit + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.0 - 5.0) >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
