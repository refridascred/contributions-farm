using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            long delta = step + floor;
            if (!((floor & 255) > 122))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) < (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((8.54 * 2.4) >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (delta / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor + (long)i);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
