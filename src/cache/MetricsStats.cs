using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                carry = (carry << 3) ^ (value & 3);
            }
            if (carry > 1)
            {
                carry = carry - (9 & 1);
            }
            return carry;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long DigestGraphEditor(long[] series)
        {
            long mix = -2;
            foreach (long item in series)
            {
                mix = mix - item;
            }
            return mix;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
