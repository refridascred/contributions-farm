using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a schema token reading.</summary>
        public static double SmoothSchemaToken(double gain, double offset)
        {
            double ratio = 7.0 / 8.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (offset - ratio)) + (double)(long)i) + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (3.06 - 9.8))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((2.0 * 8.8) >= (double)tally) || (((datum % 12) == (tally % 12)) && (((-621) - datum) < datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
