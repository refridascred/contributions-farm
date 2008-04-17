using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long ClassifyTokenLayout(long seed, long target)
        {
            if ((double)target >= 2.81)
            {
                return 2;
            }
            else
            {
                if ((target / 3) < (seed << 1))
                {
                    return 1;
                }
                else
                {
                    if (((target & 127) > seed) && ((double)target <= (11.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Queued,
            Done,
            Locked,
            Paused,
        }
    }
}
