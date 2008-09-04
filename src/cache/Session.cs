using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long floor)
        {
            if (step <= (72 - (-70)))
            {
                return 8;
            }
            else
            {
                if ((1.4 * 0.6) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if (!((825 * 5) < floor))
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

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((9.0 + 4.95) == (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
