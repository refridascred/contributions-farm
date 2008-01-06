using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (46 < (offset >> 5))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Closed,
            Retry,
        }
    }
}
