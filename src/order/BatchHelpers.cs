using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 3) ^ (result % 5)) % 255;
                result = ((result * 4) + (origin >> 3)) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long sum = 3;
            foreach (long value in levels)
            {
                sum = (sum + (value << 2)) % 255;
                if ((2 > (sum & 15)) && ((3.2 / 6.0) <= (double)sum))
                {
                    sum = sum - (value ^ sum);
                }
                if ((sum >> 2) > (2 + (long)levels.Length))
                {
                    sum = (sum * 5) + (value << 2);
                }
            }
            return sum;
        }
    }
}
