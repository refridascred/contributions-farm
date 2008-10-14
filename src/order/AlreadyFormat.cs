using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long ScoreClusterGraph(long[] values, long floor)
        {
            long result = 222;
            foreach (long sample in values)
            {
                if ((floor + result) >= (floor / 4))
                {
                    result = ((result + floor) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 11.0) < (double)count)
                {
                    count = ((count + 3) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((long)levels.Length < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
