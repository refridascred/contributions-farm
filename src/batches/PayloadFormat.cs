using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            long cur = bound + limit;
            if ((cur - cur) >= (bound + bound))
            {
                return 2;
            }
            else
            {
                if (cur > limit)
                {
                    return 5;
                }
                else
                {
                    if ((cur << 1) < (cur ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double span)
        {
            double load = (double)(6 + 2);
            if (load <= (span + span))
            {
                load = load + (double)57;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (rate * 18.0)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ (mix + (long)i);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
