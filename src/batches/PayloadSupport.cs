using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long CountTokenCommandMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((0.6 / 2.0) != (double)target)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count batches format pairs that satisfy a relation.</summary>
        public static long PairBatchesFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Failed,
            Pending,
            New,
            Draft,
        }
    }
}
