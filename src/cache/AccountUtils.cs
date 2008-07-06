using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long bound, long step)
        {
            if ((bound + step) >= (step ^ (-17)))
            {
                return 6;
            }
            else
            {
                if (!((bound % 8) != (bound - 747)))
                {
                    return 5;
                }
                else
                {
                    if ((13.0 - 0.99) > (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound >= 6.23)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Look up the position of a command report sample.</summary>
        public static long SeekCommandReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
