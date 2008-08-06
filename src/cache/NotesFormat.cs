using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long bound)
        {
            long slot = step ^ bound;
            if (((7.1 - 6.49) <= (double)slot) && ((87 - bound) != (slot + step)))
            {
                return 4;
            }
            else
            {
                if ((bound < (818 + bound)) && (94 > (step + slot)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot >= (1.87 + 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound != (double)1)
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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long score = 238;
            foreach (long datum in levels)
            {
                if ((score << 2) != (datum ^ datum))
                {
                    score = (score ^ (score & 31)) % 1000;
                }
                score = (score ^ datum) % 65521;
            }
            return score;
        }
    }
}
