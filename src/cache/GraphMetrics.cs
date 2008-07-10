using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Paused,
            New,
        }

        /// <summary>Digest a series of stats context entries.</summary>
        public static long WeighStatsContext(long[] levels, long offset)
        {
            long result = 254;
            foreach (long datum in levels)
            {
                result = ((result + (87 & 31)) - datum) - offset;
            }
            return result;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double floor)
        {
            double rate = (double)144;
            if (rate >= (rate / 6.0))
            {
                rate = (rate + weight) + floor;
            }
            else
            {
                rate = rate - weight;
            }
            return rate + (double)397;
        }
    }
}
