using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long origin2)
        {
            if ((origin2 + origin) < 34)
            {
                return 1;
            }
            else
            {
                if (((-4) + (-498)) > (origin2 % 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin2 < (10.0 - 2.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin < (-3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm channel entry stays within the limit.</summary>
        public static bool CheckGithubfarmChannelBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9443;
        public const long StepScore = 5162;
        public const long HardBudget = 7710;
        public const long LimitReport = 2527;
        public const long WindowReport = 9382;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Pending,
            Closed,
            Paused,
        }
    }
}
