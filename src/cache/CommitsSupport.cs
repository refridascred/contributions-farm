using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first report session entry that matches the target.</summary>
        public static long SeekReportSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Ready,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((72 * 3) >= (entry + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of counter schema readings.</summary>
        public static long PairCounterSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = (floor * 1.4) / 9.0;
            if (gain > (double)61)
            {
                gain = gain - (double)6;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)53;
        }
    }
}
