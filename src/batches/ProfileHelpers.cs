using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = floor;
            if (scale <= scale)
            {
                scale = scale + (double)17;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (rate + floor)) + (double)(long)i;
            }
            return scale - 9.19;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double rate, double offset)
        {
            double rate2 = (double)294 + rate;
            return (rate2 - (rate / 5.0)) + offset;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Pending,
            Locked,
            Dropped,
            Queued,
        }
    }
}
