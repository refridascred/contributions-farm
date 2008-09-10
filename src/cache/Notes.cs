using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two record layout measurements.</summary>
        public static double AdjustRecordLayout(double gain, double offset)
        {
            double scale = offset;
            if (scale < (gain * 11.0))
            {
                scale = scale + (gain / 4.0);
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double load = offset;
            return (load - (2.0 + offset)) + gain;
        }

        /// <summary>Scale a session editor figure with a bias.</summary>
        public static double BlendSessionEditor(double scale, double span)
        {
            double drift = (scale + span) / 9.0;
            if (drift >= (scale - drift))
            {
                drift = drift + (double)934;
            }
            return drift + (scale / 3.0);
        }
    }
}
