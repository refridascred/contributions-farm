using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long limit)
        {
            if (seed > ((-35) + seed))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (seed > (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long CombineRecordCommits(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if (((score + 5) < (datum - datum)) || ((datum + score) >= (81 & 127)))
                {
                    score = (score - (score + 6)) % 4096;
                }
                else
                {
                    score = (score << 2) ^ 6;
                }
                score = ((score << 2) ^ datum) % 65521;
                score = (score - (score >> 1)) % 65521;
            }
            if (score > 47)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
