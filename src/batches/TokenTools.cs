using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a window stream sample.</summary>
        public static long FindWindowStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
