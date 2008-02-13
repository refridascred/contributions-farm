using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload batches readings against a rule.</summary>
        public static long TallyPayloadBatchesMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((double)7 == (double)datum) || (matches < (matches + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
