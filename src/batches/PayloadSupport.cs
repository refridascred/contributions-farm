using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (double)count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Locked,
            Synced,
            Paused,
        }
    }
}
