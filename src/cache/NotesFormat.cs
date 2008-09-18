using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }
    }
}
