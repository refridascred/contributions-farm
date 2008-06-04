using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a format batches value against two limits.</summary>
        public static long BucketFormatBatches(long step, long origin)
        {
            long gap = step - origin;
            if (6.83 <= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((6.2 - 3.2) >= (double)origin) && (step < (333 & 127)))
                {
                    return 8;
                }
                else
                {
                    if (step < (step & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap & 1) > (gap + (-91)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double weight2 = (double)(439 % 8);
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)(-5)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (offset - weight2)) - (double)(long)i;
            }
            return weight2 + (offset * 3.6);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
