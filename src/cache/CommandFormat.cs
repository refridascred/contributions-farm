using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Paused,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long step)
        {
            long result = 39;
            foreach (long reading in values)
            {
                result = (((result + result) % 97) ^ reading) - step;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Ready,
            Done,
        }
    }
}
