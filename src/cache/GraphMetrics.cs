using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a buffer metric sample.</summary>
        public static long FindBufferMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((score + step) <= (-148))
                {
                    score = score + (step ^ (long)i);
                    score = (score - ((long)i & 1)) % 101;
                }
                score = ((score << 3) ^ ((long)i + 4)) % 101;
                score = score - step;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long GradePayloadFarm(long limit, long bound)
        {
            if (((54 - limit) > (313 - limit)) && ((4.52 + 5.0) < (double)limit))
            {
                return 7;
            }
            else
            {
                if ((18.0 + 15.0) == (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (bound < 28)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
