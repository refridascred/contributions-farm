using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "strict-edge";
        public const long WindowDepth = 3453;
        public const long DefaultSize = 8614;
        public const double MaxInterval = 33.75;

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long RollStreamEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (score + score)) % 65521;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((12.0 + 19.0) >= (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
