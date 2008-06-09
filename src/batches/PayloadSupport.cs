using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
