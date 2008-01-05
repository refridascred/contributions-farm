using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue layout input into a small class.</summary>
        public static long BucketQueueLayout(long origin, long step)
        {
            long lane = origin - step;
            if (((step >> 2) < (step & 255)) || ((origin + lane) >= origin))
            {
                return 5;
            }
            else
            {
                if ((587 <= origin) || ((lane / 7) < origin))
                {
                    return 0;
                }
                else
                {
                    if ((lane < (lane - origin)) && (step < (383 + lane)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((10.0 + 7.64) >= (double)step) || ((lane >> 1) > 95))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support stream samples.</summary>
        public static long DigestSupportStream(long[] readings)
        {
            long acc = 9;
            foreach (long value in readings)
            {
                acc = acc ^ 179;
                acc = ((acc << 3) ^ (acc << 3)) % 1000;
                if (((value >> 3) <= (acc >> 5)) && ((double)acc > (4.0 - 4.0)))
                {
                    acc = (acc ^ (value - acc)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
