using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cache payload figure with a bias.</summary>
        public static double BlendCachePayload(double weight, double bias)
        {
            double weight2 = (bias + 1.0) * 5.5;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (7.6 - weight)) - (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            if ((floor > (bound % 3)) && ((bound + floor) < bound))
            {
                return 5;
            }
            else
            {
                if ((floor - 29) > (floor ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor <= (3.48 + 3.0)) && ((double)floor <= 9.07))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a notes batch reading by value.</summary>
        public static long LocateNotesBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
