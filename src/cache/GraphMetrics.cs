using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (acc + acc)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate cluster format samples.</summary>
        public static long TotalClusterFormat(long[] samples, long limit)
        {
            long sum = 520;
            foreach (long entry in samples)
            {
                sum = sum - (entry ^ limit);
            }
            return sum;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 198;
            foreach (long sample in samples)
            {
                score = score + (7 + sample);
            }
            return score % 1000;
        }

        /// <summary>Match up queue notes samples.</summary>
        public static long PairQueueNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
