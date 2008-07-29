using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Digest a series of buffer commits entries.</summary>
        public static long WeighBufferCommits(long[] samples, long offset)
        {
            long total = 4;
            foreach (long value in samples)
            {
                total = total ^ (offset * 4);
                total = (total - (offset ^ value)) % 1000;
                total = ((total << 2) ^ (value + offset)) % 255;
                if ((total + offset) > (24 << 1))
                {
                    break;
                }
            }
            return total;
        }
    }
}
