using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double load = (4.0 + 9.4) - weight;
            if (load > (double)22)
            {
                load = (load - (double)42) - bias;
            }
            return load - (double)9;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ (-5)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(9 < (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 2) > (count >> 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
