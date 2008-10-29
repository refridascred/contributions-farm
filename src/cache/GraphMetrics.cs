using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data)
        {
            long mark = 50;
            foreach (long sample in data)
            {
                mark = (mark ^ (mark & 63)) + sample;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 813;
            foreach (long entry in levels)
            {
                sum = (sum ^ (990 - entry)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Adjust a batches schema reading.</summary>
        public static double SmoothBatchesSchema(double rate, double floor)
        {
            double drift = 7.4;
            if (drift >= rate)
            {
                drift = drift + floor;
            }
            return drift + floor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            long span = offset + bound;
            if (((34 + span) == (bound & 15)) && ((bound + bound) != (span + span)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.99 * 9.65))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
