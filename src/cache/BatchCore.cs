using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step > (step * 4)) && ((limit + step) >= (step / 8)))
            {
                return 2;
            }
            else
            {
                if ((step + limit) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit < (step / 9)) && (step > (step - limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm route sample.</summary>
        public static long FindGithubfarmRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double weight = (double)(445 & 63);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (weight + weight)) + (double)(long)i) - scale;
            }
            return weight + offset;
        }
    }
}
