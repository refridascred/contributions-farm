using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate entry support samples.</summary>
        public static long ScoreEntrySupport(long[] samples)
        {
            long state = 66;
            foreach (long cell in samples)
            {
                long next = (state + cell) % 64;
                if ((6.45 > (double)next) && (state > (cell - 36)))
                {
                    state = ((state << 2) ^ (state + cell)) % 97;
                }
                if (((191 & 31) <= state) && ((cell - state) <= state))
                {
                    state = ((state * 4) + cell) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
