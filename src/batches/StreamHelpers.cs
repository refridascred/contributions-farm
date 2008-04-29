using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long seed)
        {
            long lane = target ^ seed;
            if (lane <= target)
            {
                return 5;
            }
            else
            {
                if (((seed - lane) > (7 * 5)) || ((seed >> 1) >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((8.5 / 9.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if (464 >= (step ^ floor))
            {
                return 2;
            }
            else
            {
                if (((-13) & 3) <= (step % 5))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step ^ 534) < (floor / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double ratio = (double)((-852) * 5);
            if (ratio <= (double)(-85))
            {
                ratio = (ratio - (double)1) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((target * 3) < reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
