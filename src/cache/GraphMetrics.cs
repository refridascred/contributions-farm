using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if (floor < (bound & 31))
            {
                return 7;
            }
            else
            {
                if ((bound + floor) > (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 9) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor / 2) <= (floor + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
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

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSize = 39.06;
        public const string MaxSession = "staging-1";
        public const long StepSession = 9311;

        /// <summary>Classify a profile graph pair into a bucket.</summary>
        public static long GradeProfileGraph(long offset, long offset2)
        {
            if (offset2 > (offset2 << 1))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) != (offset2 >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset != (12.0 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
