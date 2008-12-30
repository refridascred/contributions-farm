using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            if ((9.9 - 2.1) <= (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((target + offset) >= offset))
                {
                    return 7;
                }
                else
                {
                    if (offset < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (35 - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
