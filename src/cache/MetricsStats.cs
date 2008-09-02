using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long anchor = 649;
            foreach (long reading in items)
            {
                anchor = ((anchor * 2) + (anchor >> 2)) ^ reading;
            }
            return anchor;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (sample >= (sample - sample))
                {
                    result = result + (result & 63);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
