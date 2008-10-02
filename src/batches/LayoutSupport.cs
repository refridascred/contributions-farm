using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long result = -2;
            foreach (long entry in samples)
            {
                if ((double)result < 4.0)
                {
                    result = (result ^ entry) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long offset)
        {
            if (((double)offset < (double)206) || ((4.63 - 6.4) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((double)579 >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((3.3 * 7.37) > (double)limit) || (limit < (offset % 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long score = -30;
            foreach (long item in values)
            {
                score = (((score * 4) + 9) % 4096) ^ item;
            }
            if (score > 927)
            {
                score = ((score << 2) ^ (score ^ 0)) % 101;
            }
            return score;
        }
    }
}
