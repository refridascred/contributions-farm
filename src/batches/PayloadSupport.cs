using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate entry stream readings against a bound.</summary>
        public static bool VerifyEntryStreamBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 >= (2.44 - 9.54))
            {
                return 3;
            }
            else
            {
                if (!(bound < (step ^ step)))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound2 < (3.62 / 3.0)) && ((4 + step) <= (step - bound2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (9.0 - 5.3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
