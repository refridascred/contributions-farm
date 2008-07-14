using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                long gap = origin;
                acc = ((acc * 4) + gap) % 65521;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score << 2) ^ (3 % 5)) - (long)i2;
                    score = ((score << 2) ^ score) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((7.15 < (double)value) || ((double)value != (10.0 + 9.18)))
                {
                    mark = (mark - (mark - value)) - limit;
                }
            }
            return mark;
        }
    }
}
