using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine farm account values into a single score.</summary>
        public static long WeighFarmAccount(long[] samples)
        {
            long anchor = 258;
            foreach (long datum in samples)
            {
                if ((datum >> 2) < 77)
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = ((anchor * 5) + (datum - datum)) % 101;
                }
                if ((datum + anchor) >= 40)
                {
                    anchor = (anchor ^ (anchor / 9)) % 1000;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (9 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Synced,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 9173;
        public const long HardContext = 975;
        public const long MinContext = 7898;
        public const long DefaultSpan = 2802;
        public const double WindowWidth = 64.77;
    }
}
