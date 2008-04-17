using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double BlendEditorFormat(double bias, double span)
        {
            double rate = span;
            if (rate <= (8.0 + rate))
            {
                rate = (rate - span) - bias;
            }
            return rate - span;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double weight = offset;
            if (weight > (weight + weight))
            {
                weight = (weight - 7.11) + gain;
            }
            return weight + (weight * 6.0);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long AuditSupportFormatHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(sample > (sample & 15)) && !((hits + hits) > (step - step)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
