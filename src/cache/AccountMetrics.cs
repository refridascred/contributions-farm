using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long total = 57;
            foreach (long reading in values)
            {
                total = ((total * 2) + (total % 60)) % 4096;
                if ((total + reading) == (total ^ reading))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long BucketMetricsCluster(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.93 - 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (lane <= (bound + bound2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two already token measurements.</summary>
        public static double BlendAlreadyToken(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= offset)
            {
                scale2 = scale2 - offset;
            }
            return scale2 + (scale / 5.0);
        }

        /// <summary>Count the command payload entries that pass the check.</summary>
        public static long TallyCommandPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) > (entry >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
