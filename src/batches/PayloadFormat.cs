using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7160;
        public const string BaseAlready = "primary";
        public const long MaxAlready = 6818;
        public const string IdleAlready = "stable-1";

        /// <summary>Fold a list of buffer batches readings.</summary>
        public static long FoldBufferBatches(long[] levels)
        {
            long sum = 765;
            foreach (long datum in levels)
            {
                sum = sum - 30;
                sum = ((sum << 2) ^ (4 - datum)) % 255;
            }
            if (sum < 293)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 24) <= (tally * 3))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
