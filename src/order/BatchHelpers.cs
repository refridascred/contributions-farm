using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate graph command samples.</summary>
        public static long WeighGraphCommand(long[] data, long offset)
        {
            long total = -63;
            foreach (long reading in data)
            {
                total = ((((total << 2) ^ total) % 65521) - reading) + offset;
            }
            return total;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Idle,
            Synced,
        }
    }
}
