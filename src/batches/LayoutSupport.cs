using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Failed,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double scale = (double)(50 >> 3);
            if (scale <= gain)
            {
                scale = (scale + scale) + offset;
            }
            return scale - gain;
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long CompareLayoutWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Paused,
            Pending,
            New,
        }
    }
}
