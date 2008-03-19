using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter cluster entries that pass the check.</summary>
        public static long CountFilterClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum / 6) == (datum * 4)) && (((long)samples.Length / 8) > (511 + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Paused,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long target)
        {
            long lane = step + target;
            if ((target + target) < (623 + target))
            {
                return 5;
            }
            else
            {
                if (((double)lane > (9.18 / 3.0)) || (step < lane))
                {
                    return 3;
                }
                else
                {
                    if (lane < (lane - 237))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-403) % 5) == (lane % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
