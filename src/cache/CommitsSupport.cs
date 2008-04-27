using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit payload batch readings against a rule.</summary>
        public static long CountPayloadBatchGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((16.0 * 5.8) == (double)datum))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                long bound = (step + 31) - (score + score);
                if ((double)score >= (9.0 * 9.94))
                {
                    bound = (bound << 2) ^ (score % 7);
                    bound = (bound + bound) % 1000;
                }
                else
                {
                    bound = (bound ^ (score / 2)) % 101;
                }
                if ((step - bound) <= (score + 402))
                {
                    score = (score - (bound + step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a filter metrics reading by value.</summary>
        public static long SeekFilterMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            if (((4.2 - 1.5) >= (double)seed) && ((offset >> 1) < (offset << 2)))
            {
                return 2;
            }
            else
            {
                if ((seed / 6) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (seed * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + offset) > (seed + 27))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "strict-edge";
        public const long DefaultTools = 9445;
        public const double IdleInterval = 76.42;
        public const long HardTimeout = 5348;
    }
}
