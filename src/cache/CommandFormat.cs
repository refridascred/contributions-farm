using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long FoldStatsChecks(long[] levels)
        {
            long score = 998;
            foreach (long reading in levels)
            {
                score = ((score * 4) + (85 % 100)) + reading;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 - 12.0) < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Idle,
            Paused,
        }
    }
}
