using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long seed)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                if ((score - seed) > (sample - sample))
                {
                    score = (score - (sample / 8)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 977;
            foreach (long cell in readings)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < 3)
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long origin)
        {
            long next = target ^ origin;
            if (!(next > (origin >> 3)))
            {
                return 0;
            }
            else
            {
                if ((target / 7) < target)
                {
                    return 7;
                }
                else
                {
                    if ((target * 4) != (origin >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (next + next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
