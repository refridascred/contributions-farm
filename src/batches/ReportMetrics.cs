using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = 647;
            foreach (long datum in series)
            {
                if ((anchor & 63) < (3 >> 2))
                {
                    anchor = (anchor + (anchor % 60)) % 4096;
                }
                anchor = ((anchor << 2) ^ (anchor + datum)) % 255;
            }
            if (anchor < (-3))
            {
                anchor = (anchor ^ (-48)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
