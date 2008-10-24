using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long origin)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                mark = ((mark - (5 + origin)) % 97) + entry;
            }
            if (mark > 9)
            {
                mark = (mark ^ origin) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 97) >= (value & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Dropped,
        }
    }
}
