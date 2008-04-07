using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double offset)
        {
            double load = (offset - scale) * 16.0;
            if (load <= scale)
            {
                load = load + (double)186;
            }
            else
            {
                load = load + (load + load);
            }
            return load - offset;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (limit >= diff)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= 8.58) || ((1 & 255) >= (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    if (((-583) / 6) < (bound + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff < (7.4 - 6.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
