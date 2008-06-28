using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long CountCounterCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item >= (647 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((floor * 4) == (10 + matches)) || ((cell >= (floor + matches)) && (floor > (floor + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double weight = 9.34;
            if (weight >= (double)(-6))
            {
                weight = (weight - weight) + scale;
            }
            return weight + bias;
        }
    }
}
