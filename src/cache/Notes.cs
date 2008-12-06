using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two farm editor measurements.</summary>
        public static double AdjustFarmEditor(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 > (8.4 - bias))
            {
                bias2 = bias2 - (double)18;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (gain + bias)) - (double)(long)i;
            }
            return bias2 + (double)458;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                if ((64 ^ cell) > anchor)
                {
                    anchor = (anchor * 3) + (cell + anchor);
                }
                anchor = (anchor + (cell % 16)) % 101;
                if ((12 - anchor) <= (6 << 1))
                {
                    anchor = (anchor ^ (cell - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
