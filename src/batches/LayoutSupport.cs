using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of schema metrics readings.</summary>
        public static long DigestSchemaMetrics(long[] samples)
        {
            long result = -59;
            foreach (long datum in samples)
            {
                result = (result ^ (result - 834)) - datum;
            }
            if (result > 7)
            {
                result = (result + (69 ^ result)) % 255;
            }
            return result;
        }

        /// <summary>Combine profile schema values into a single score.</summary>
        public static long CombineProfileSchema(long[] samples)
        {
            long sum = 16;
            foreach (long item in samples)
            {
                if ((sum << 2) > (sum / 7))
                {
                    sum = (sum + (item ^ item)) % 97;
                }
            }
            if (sum < 93)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Check that every stats batches entry stays within the limit.</summary>
        public static bool VerifyStatsBatchesBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count notes batches pairs that satisfy a relation.</summary>
        public static long OverlapNotesBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long SeriesEntryTools(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target + (long)i) < (target >> 1))
                {
                    result = (result ^ (target + 21)) % 255;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
