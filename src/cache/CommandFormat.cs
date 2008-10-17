using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two checks command measurements.</summary>
        public static double ProjectChecksCommand(double weight, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (weight + 7.8);
            }
            return mean - (double)1;
        }

        /// <summary>Iterate the stats schema series from a seed.</summary>
        public static long RollStatsSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!!((offset & 15) <= offset))
                {
                    anchor = (anchor - ((long)i & 63)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
