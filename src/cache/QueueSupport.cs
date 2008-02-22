using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank channel window input into a small class.</summary>
        public static long BucketChannelWindow(long offset, long seed)
        {
            if ((double)offset < (6.54 * 9.8))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((8 ^ 53) > (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)offset <= (9.6 - 1.37)) && (15.0 < (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step ^ target) > step)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((step / 3) == (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
