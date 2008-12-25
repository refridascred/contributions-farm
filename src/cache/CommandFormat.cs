using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of commits record readings.</summary>
        public static long DigestCommitsRecord(long[] items)
        {
            long state = 6;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample - sample)) % 65521;
                if (((state / 8) <= sample) || (state < (sample * 5)))
                {
                    state = (state + (sample >> 4)) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > 42)
            {
                state = (state - (2 * 4)) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of filter notes readings.</summary>
        public static long MatchFilterNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 4) != (seen - 104))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
