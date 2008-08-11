using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double load = (2.0 / 5.0) * 4.33;
            if (load < scale)
            {
                load = load + load;
            }
            return load + (load - floor);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((5.0 * 7.96) == (double)tally)
                {
                    tally = ((tally + 3) ^ cell) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Idle,
            Done,
            Pending,
            Active,
        }
    }
}
