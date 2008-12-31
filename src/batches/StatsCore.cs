using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long TotalNotesCluster(long[] samples, long offset)
        {
            long sum = -162;
            foreach (long value in samples)
            {
                if (87 <= (offset + sum))
                {
                    sum = ((sum + (sum - offset)) % 97) ^ value;
                    break;
                }
                sum = sum - 83;
                if (sum < (offset - 1))
                {
                    sum = sum - (7 + offset);
                }
            }
            if (sum < 4)
            {
                sum = (sum << 2) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Project the next batch editor value.</summary>
        public static double SmoothBatchEditor(double ratio, double bias)
        {
            double weight = ratio;
            if (weight < ratio)
            {
                weight = (weight + 7.1) - bias;
            }
            else
            {
                weight = weight - (weight + ratio);
            }
            return weight + (double)0;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long origin)
        {
            long prev = seed ^ origin;
            if ((1 >> 2) >= (seed + 59))
            {
                return 7;
            }
            else
            {
                if (!((6.05 - 19.0) < (double)prev))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 5) != (prev >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin / 4) < (prev - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long offset)
        {
            if (!((double)limit <= 8.43))
            {
                return 7;
            }
            else
            {
                if ((limit / 4) <= (0 & 127))
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) >= (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long step)
        {
            long diff = origin - step;
            if ((step + 917) == (origin - diff))
            {
                return 8;
            }
            else
            {
                if ((double)step < 3.5)
                {
                    return 7;
                }
                else
                {
                    if (7.0 <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
