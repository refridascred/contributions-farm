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

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 5912;
        public const long SoftInterval = 3361;
        public const long BurstNotes = 9749;
        public const long MaxWidth = 280;
        public const double WindowCount = 94.92;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Retry,
            Queued,
            Done,
        }
    }
}
