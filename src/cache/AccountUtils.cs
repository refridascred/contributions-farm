using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long bound)
        {
            if ((step & 3) > ((-54) >> 2))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) != (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if (step < (bound % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > 518)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Look up the position of a record channel sample.</summary>
        public static long SeekRecordChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
