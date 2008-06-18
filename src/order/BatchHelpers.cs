using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = ((score << 3) ^ (datum + score)) % 101;
                if ((double)seed <= (double)datum)
                {
                    score = ((score * 2) + 4) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a account buffer value against two limits.</summary>
        public static long ClassifyAccountBuffer(long bound, long step)
        {
            long gap = bound - step;
            if ((double)(-537) >= (double)gap)
            {
                return 1;
            }
            else
            {
                if ((bound <= (0 >> 1)) && ((bound ^ bound) != (step % 7)))
                {
                    return 0;
                }
                else
                {
                    if (bound < gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((1.96 - 3.9) >= (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings, long step)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                score = ((score * 4) + (entry & 127)) % 255;
                if (((double)score >= (4.47 - 6.39)) || ((entry >> 5) == (step - (long)readings.Length)))
                {
                    score = (score ^ (score + score)) % 255;
                    break;
                }
                else
                {
                    score = score ^ score;
                }
                if ((double)step <= 8.03)
                {
                    score = (score * 2) + entry;
                }
            }
            return score % 97;
        }
    }
}
