using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Dropped,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the route schema series from a seed.</summary>
        public static long SeriesRouteSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = (total - ((long)i + target)) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long result = 216;
            foreach (long value in samples)
            {
                if (((long)samples.Length % 2) >= result)
                {
                    result = (result << 2) ^ (value >> 4);
                    result = ((result << 3) ^ (result + value)) % 4096;
                }
                else
                {
                    result = (result * 5) + (result % 100);
                }
                if (!((value << 1) < value))
                {
                    result = ((result * 2) + ((-5) + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((39 / 9) >= (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
