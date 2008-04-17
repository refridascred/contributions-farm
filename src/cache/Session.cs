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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((1.0 / 9.0) <= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
