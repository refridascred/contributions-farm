using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank filter tools input into a small class.</summary>
        public static long GradeFilterTools(long limit, long seed)
        {
            if ((seed - limit) > seed)
            {
                return 0;
            }
            else
            {
                if (((seed ^ seed) == (seed >> 2)) || ((double)limit < (5.0 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Total { get; set; }
            public bool Token { get; set; }
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
