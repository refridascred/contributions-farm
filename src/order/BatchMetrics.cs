using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double ratio = (double)0 / 2.0;
            if (ratio <= (weight / 7.0))
            {
                ratio = (ratio + (ratio * 6.67)) - span;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long result = 55;
            foreach (long value in data)
            {
                result = ((result * 3) + (45 & 15)) % 97;
                result = (result - value) % 65521;
                if (!(floor <= (floor + value)))
                {
                    result = (result - (floor + 3)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (value + floor);
                }
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSpan = "strict-edge";
        public const double HardLevel = 74.64;
        public const string SoftSize = "latest-edge";

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long limit)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                if (((long)values.Length + mark) >= (mark / 7))
                {
                    mark = ((mark * 3) + (entry * 5)) - limit;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long step)
        {
            long score = 76;
            foreach (long sample in items)
            {
                if (sample > (step - sample))
                {
                    score = (score ^ (score + sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count batch filter pairs that satisfy a relation.</summary>
        public static long MatchBatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
