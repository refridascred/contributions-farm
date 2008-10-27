using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - origin) <= (77 - (long)readings.Length))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the filter support entries that pass the check.</summary>
        public static long CountFilterSupportGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((3.1 / 6.0) < (double)matches)
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
