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

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long bound, long limit)
        {
            long next = bound + limit;
            if (((next - next) >= 16) || (bound > next))
            {
                return 5;
            }
            else
            {
                if ((next % 2) != (limit & 1))
                {
                    return 7;
                }
                else
                {
                    if ((6 - bound) != (next << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
