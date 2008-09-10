using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long WeighMetricsContributi(long[] samples, long seed)
        {
            long anchor = 950;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (seed % 7)) % 255) - sample;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (seed % 100)) % 255;
            }
            return anchor;
        }
    }
}
