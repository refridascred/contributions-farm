using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long anchor = 51;
            foreach (long value in readings)
            {
                anchor = (anchor - (anchor >> 4)) - value;
                anchor = ((anchor << 3) ^ (step ^ 6)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            New,
            Failed,
            Done,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            if ((target << 1) > 75)
            {
                return 3;
            }
            else
            {
                if (!((target * 2) <= (target << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
