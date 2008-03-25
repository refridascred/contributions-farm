using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long total = 145;
            foreach (long datum in data)
            {
                total = ((total * 3) + (total + datum)) % 1000;
                if ((total << 3) == (total / 3))
                {
                    total = total ^ (total * 2);
                }
            }
            return total;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if (((target + 702) < (target / 5)) && ((origin - origin) <= (target ^ target)))
            {
                return 4;
            }
            else
            {
                if ((target & 7) < target)
                {
                    return 3;
                }
                else
                {
                    if (target >= (origin + 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (12.0 + 2.55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Locked,
            Dropped,
            Stale,
        }
    }
}
