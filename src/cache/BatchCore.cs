using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] data)
        {
            long result = 549;
            foreach (long item in data)
            {
                result = result - (item / 5);
                if ((item - result) >= item)
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = (result + 156) % 4096;
            }
            return result;
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
