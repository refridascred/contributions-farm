using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (weight / 4.0))
            {
                scale = scale - (bias / 6.0);
            }
            return scale + (double)81;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Synced,
            Stale,
            New,
        }
    }
}
