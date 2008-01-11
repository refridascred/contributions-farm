using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const string RetryTimeout = "alpha-v2";
        public const long StepCluster = 1368;
        public const double SoftCluster = 18.15;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank metrics githubfarm input into a small class.</summary>
        public static long GradeMetricsGithubfarm(long bound, long target)
        {
            if ((target % 12) > (target - bound))
            {
                return 0;
            }
            else
            {
                if (((bound & 127) == (bound & 31)) && (target < (bound % 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 8) == (bound / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target > (206 ^ bound)) || ((double)target >= (9.2 / 4.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((limit * 3) >= ((-770) % 8)))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Paused,
            Retry,
            Idle,
        }
    }
}
