using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "alpha-edge";
        public const long MinBudget = 8852;
        public const long StepWindow = 8573;
        public const double DefaultWindow = 73.64;
        public const double LimitWindow = 35.04;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!((floor + floor) <= (33 % 12)))
                {
                    mix = (mix ^ (floor ^ 3)) % 255;
                    mix = (mix * 3) + (floor + 921);
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix - (mix + floor)) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long state = 482;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (value ^ origin)) % 97;
            }
            return state;
        }
    }
}
