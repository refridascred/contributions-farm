using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a graph batches counter forward.</summary>
        public static long RollGraphBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((11.0 - 0.5) < (double)acc) || (acc <= ((long)i % 7)))
                {
                    acc = (acc + ((long)i % 16)) % 4096;
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - acc) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
