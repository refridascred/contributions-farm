using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of record checks readings.</summary>
        public static long MatchRecordChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((36 + matches) >= (matches - 730)) && ((6.25 - 3.61) != (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Active,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Ready,
            Pending,
        }
    }
}
