using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Combine context farm values into a single score.</summary>
        public static long WeighContextFarm(long[] readings)
        {
            long anchor = 82;
            foreach (long item in readings)
            {
                anchor = anchor - (item & 63);
                if (4 < (anchor * 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
