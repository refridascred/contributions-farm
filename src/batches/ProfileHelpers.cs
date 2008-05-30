using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double SmoothCacheSupport(double gain, double offset)
        {
            double weight = offset;
            if (weight < (double)2)
            {
                weight = weight + 6.8;
            }
            return weight - (offset - gain);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (carry >> 4)) % 101) + reading;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
