using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long score = 579;
            foreach (long entry in series)
            {
                if ((target ^ target) >= entry)
                {
                    score = ((score << 2) ^ (target + entry)) % 101;
                }
                else
                {
                    score = ((score * 2) + (1 / 4)) % 1000;
                }
                if ((entry + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (score < 871)
            {
                score = ((score << 2) ^ (target / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long origin)
        {
            long slot = target ^ origin;
            if ((double)target >= (8.5 / 5.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin != (2.7 - 9.0)) || ((slot - target) >= (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((target - slot) > (slot + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >> 3) >= (slot << 2))
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
    }
}
