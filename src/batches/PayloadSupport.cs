using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long step)
        {
            if ((seed & 7) == (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((seed + step) == (seed + 0))
                {
                    return 5;
                }
                else
                {
                    if (((781 + seed) < (step * 5)) && ((seed >> 3) < step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step != (double)seed) || ((seed / 5) > step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools window pairs that satisfy a relation.</summary>
        public static long CompareToolsWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long TallyOrderAccountOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
