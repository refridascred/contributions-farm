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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings)
        {
            long result = -21;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.65 / 8.0))
                {
                    result = result ^ (reading * 5);
                }
                else
                {
                    result = result + 75;
                }
            }
            if (result < 4)
            {
                result = (result + (result - result)) % 101;
            }
            return result;
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
