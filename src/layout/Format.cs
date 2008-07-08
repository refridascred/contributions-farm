using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double ratio2 = (double)(776 << 2);
            if (ratio2 > (ratio + 2.18))
            {
                ratio2 = (ratio2 - (ratio2 / 7.0)) - offset;
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a session commits sample.</summary>
        public static long FindSessionCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 1734;
        public const long HardScore = 4346;
        public const string DefaultRoute = "primary-v2";
        public const long BaseRoute = 6945;
    }
}
