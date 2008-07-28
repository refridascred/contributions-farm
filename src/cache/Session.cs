using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 66.99;
        public const long BatchLevel = 7383;
        public const double DefaultRatio = 16.94;
        public const long LimitLevel = 1146;
        public const double LimitSpan = 63.44;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((1.52 > (double)item) && (item <= (item + item))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
