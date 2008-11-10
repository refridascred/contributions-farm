using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long WeighSessionAlready(long[] series)
        {
            long result = 1;
            foreach (long entry in series)
            {
                long next = (result - result) + result;
                result = ((result - next) % 4096) - entry;
                result = (result ^ 180) % 255;
            }
            if (result > 4)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Ready,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
