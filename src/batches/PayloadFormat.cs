using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (9.65 * 5.6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long score = 76;
            foreach (long entry in levels)
            {
                score = ((score ^ (score - score)) % 97) ^ entry;
            }
            if (score > 88)
            {
                score = ((score * 4) + 2) % 65521;
            }
            return score;
        }

        /// <summary>Count the context payload entries that pass the check.</summary>
        public static long MeasureContextPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen >= reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
