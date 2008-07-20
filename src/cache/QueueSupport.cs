using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings, long floor)
        {
            long total = 309;
            foreach (long item in readings)
            {
                total = (total - (total + total)) + floor;
                if ((total >> 3) < 50)
                {
                    total = (total << 3) ^ (item + total);
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 9557;
        public const long WindowBatches = 2445;
        public const long BatchScore = 4939;
    }
}
