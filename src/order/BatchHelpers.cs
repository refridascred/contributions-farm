using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long TallySupportToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
