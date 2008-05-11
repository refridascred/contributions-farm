using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseRatio = 71;
        public const string IdleGraph = "local-1";
        public const long IdleFactor = 1646;
        public const long HardRatio = 7351;
        public const long BatchGraph = 1846;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
