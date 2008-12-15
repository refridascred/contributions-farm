using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Pending,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor + step) <= (origin % 2))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long target)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score - ((long)levels.Length / 9)) + cell) + target;
                score = (score ^ 8) % 65521;
            }
            return score;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (5.0 - 6.6))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
