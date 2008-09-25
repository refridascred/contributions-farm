using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long datum in readings)
            {
                anchor = (anchor + (datum / 2)) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Combine window schema values into a single score.</summary>
        public static long TotalWindowSchema(long[] data, long offset)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                sum = (((sum * 5) + (offset & 63)) % 255) ^ reading;
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Combine account channel values into a single score.</summary>
        public static long ScoreAccountChannel(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                anchor = anchor ^ item;
            }
            return anchor % 65521;
        }
    }
}
