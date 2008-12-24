using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(sample > (66 >> 3)))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Dropped,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Paused,
            Active,
            Closed,
            Failed,
        }
    }
}
