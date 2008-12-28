using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long acc = 788;
            foreach (long cell in series)
            {
                if ((acc - cell) > cell)
                {
                    acc = acc ^ acc;
                }
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc * 3) + acc) + (long)i;
                }
                if (((long)series.Length - acc) > cell)
                {
                    acc = ((acc * 5) + (acc % 10)) % 4096;
                }
            }
            if (acc > 162)
            {
                acc = acc - (4 & 15);
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((-4) * 4) >= matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
