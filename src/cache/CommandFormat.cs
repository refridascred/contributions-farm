using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many account channel samples are out of range.</summary>
        public static long MeasureAccountChannelGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((origin ^ origin) <= tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((5 % 8) <= (long)values.Length) && ((4 << 3) >= (item - (long)values.Length))) && ((double)item == (20.0 - 1.7)))
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
    }
}
