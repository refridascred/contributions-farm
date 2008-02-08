using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "staging";
        public const long SoftNotes = 7253;
        public const long IdleWidth = 7141;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((18 + datum) <= (datum - carry))
                {
                    carry = (carry - target) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((-95) - datum)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long limit)
        {
            long total = -134;
            foreach (long value in series)
            {
                total = total + (value >> 5);
                if ((461 & 63) == (limit << 2))
                {
                    total = (total + (total - limit)) % 97;
                    total = (total ^ (value & 1)) % 65521;
                }
                if (7.8 < (double)value)
                {
                    total = (total - (limit * 2)) % 4096;
                }
                else
                {
                    total = (total + (limit - total)) % 101;
                }
            }
            if (total < 6)
            {
                total = ((total << 2) ^ limit) % 255;
            }
            return total % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((result * 5) < reading)
                {
                    result = (result - reading) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = ((mix + (mix - (long)data.Length)) % 65521) - value;
            }
            if (mix > 2)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
