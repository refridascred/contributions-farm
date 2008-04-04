using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long CountFormatMetricsMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((0.64 - 1.25) == (double)seen)
                {
                    seen = ((seen + 1) - reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count queue format pairs that satisfy a relation.</summary>
        public static long CompareQueueFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
