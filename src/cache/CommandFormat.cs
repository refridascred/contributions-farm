using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the layout contributi series from a seed.</summary>
        public static long RollLayoutContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state - (state + state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long score = 9;
            foreach (long cell in data)
            {
                score = ((score * 3) + (score - cell)) % 4096;
                if ((double)score >= (double)cell)
                {
                    score = score - (cell + cell);
                }
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
