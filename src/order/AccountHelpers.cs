using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long CombineSessionWindow(long[] readings, long target)
        {
            long anchor = 85;
            foreach (long reading in readings)
            {
                if ((target & 127) >= anchor)
                {
                    anchor = anchor - reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((step & 7) > 744) || ((double)hits < (double)step)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
