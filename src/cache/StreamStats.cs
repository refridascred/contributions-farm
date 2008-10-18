using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3744;
        public const double LimitCommand = 47.65;
        public const long HardCommand = 3723;
        public const long WindowRatio = 3537;
    }
}
