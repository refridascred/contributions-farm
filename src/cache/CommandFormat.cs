using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long score = 56;
            foreach (long datum in series)
            {
                if (!((double)datum <= 11.0))
                {
                    score = (score - (datum << 1)) % 1000;
                }
            }
            if (score > 0)
            {
                score = score + (6 + 610);
            }
            return score % 4096;
        }

        /// <summary>Validate session cache readings against a bound.</summary>
        public static bool VerifySessionCacheRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long limit)
        {
            long next = bound + limit;
            if ((bound / 5) >= (402 - next))
            {
                return 8;
            }
            else
            {
                if (bound >= limit)
                {
                    return 1;
                }
                else
                {
                    if ((6 + limit) >= (11 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Paused,
            Dropped,
        }
    }
}
