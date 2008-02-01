using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            if (0 > (bound + limit))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (8 < (bound * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 - 14.0) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Active,
            Done,
        }

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long MeasureProfileCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)sample >= (6.2 - 5.7)) || ((sample ^ seen) >= (262 + 0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series, long step)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = (((score ^ score) % 1000) + cell) + step;
            }
            if (score < 335)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
