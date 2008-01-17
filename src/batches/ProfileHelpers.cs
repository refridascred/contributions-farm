using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long MeasureGraphCommitsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits % 3) > (hits + hits)) || ((8.0 - 12.0) > (double)(long)samples.Length))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowScore = 2185;
        public const long MaxRatio = 8404;
        public const double HardScore = 90.0;
        public const long WindowTimeout = 2563;
        public const long MaxCommits = 2847;

        /// <summary>Iterate the token counter series from a seed.</summary>
        public static long RollTokenCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (offset - 89)) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 << 3)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long target)
        {
            long result = 28;
            foreach (long entry in values)
            {
                if (!(target >= entry))
                {
                    result = (result << 2) ^ (target + 8);
                }
            }
            return result;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
