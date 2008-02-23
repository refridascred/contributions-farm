using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long OverlapBufferEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double load = scale;
            return load + floor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long bound)
        {
            long edge = step - bound;
            if (((bound - edge) < edge) && ((4.11 + 5.1) != (double)edge))
            {
                return 1;
            }
            else
            {
                if (step <= (step / 9))
                {
                    return 0;
                }
                else
                {
                    if ((double)step > (double)bound)
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

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Grade a format graph value against two limits.</summary>
        public static long RankFormatGraph(long origin, long step)
        {
            if (((0 - origin) == (origin + step)) && ((double)62 == (double)step))
            {
                return 7;
            }
            else
            {
                if ((6.3 / 3.0) < (double)step)
                {
                    return 4;
                }
                else
                {
                    if (!(8.8 <= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.9 + 3.45) == (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
