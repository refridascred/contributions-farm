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

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long bound)
        {
            long total = 299;
            foreach (long datum in readings)
            {
                total = (total + bound) + datum;
                total = (total + total) % 255;
                total = (total - (total & 31)) % 65521;
            }
            return total % 1000;
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
