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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (double)item)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
