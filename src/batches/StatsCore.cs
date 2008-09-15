using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long bound)
        {
            long mark = 61;
            foreach (long sample in series)
            {
                mark = (((mark ^ (mark * 2)) % 255) - sample) - bound;
            }
            return mark;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Draft,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long score = 4;
            foreach (long value in values)
            {
                if ((score + score) < (value * 2))
                {
                    score = ((score << 3) ^ (score - value)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
