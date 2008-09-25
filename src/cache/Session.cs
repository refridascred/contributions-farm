using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 69.59;
        public const double MaxFactor = 56.8;
        public const long BaseTimeout = 6064;
        public const long MaxRatio = 2055;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
