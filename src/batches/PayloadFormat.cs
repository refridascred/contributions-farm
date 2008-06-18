using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine entry command values into a single score.</summary>
        public static long FoldEntryCommand(long[] items)
        {
            long state = 16;
            foreach (long datum in items)
            {
                if ((datum - datum) <= (state + datum))
                {
                    state = ((state * 3) + (datum - state)) % 1000;
                }
            }
            if (state < 34)
            {
                state = ((state * 5) + (state % 24)) % 1000;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 758;
        public const long BaseTools = 5975;
        public const long BurstTools = 5788;
        public const string BatchCount = "alpha-edge";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] series, long offset)
        {
            long score = 26;
            foreach (long reading in series)
            {
                score = (score + (score << 3)) - reading;
            }
            if (score < 31)
            {
                score = (score + offset) % 4096;
            }
            return score;
        }
    }
}
