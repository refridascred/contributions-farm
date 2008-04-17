using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item <= (item - item)) || (item <= (item & 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
