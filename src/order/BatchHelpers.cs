using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series, long target)
        {
            long mix = 92;
            foreach (long value in series)
            {
                if (!((double)target > (4.0 - 9.0)))
                {
                    mix = (mix ^ (901 >> 2)) % 101;
                    mix = mix + (value << 3);
                }
                if ((value - 1) < (target - value))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
            }
            if (mix > 9)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4.69 + 4.57) < (double)matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
