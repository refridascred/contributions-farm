using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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
