using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long anchor = 389;
            foreach (long datum in samples)
            {
                if ((datum + (-269)) < datum)
                {
                    anchor = ((anchor * 2) + (datum * 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (8 / 9)) % 97;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 945;
            foreach (long entry in readings)
            {
                if (((-625) % 60) <= (carry + carry))
                {
                    carry = (carry ^ (entry & 31)) % 255;
                }
                if (((18 / 7) > (entry + entry)) && (((long)readings.Length >> 2) == (carry << 2)))
                {
                    carry = ((carry << 2) ^ 9) % 255;
                    carry = (carry << 2) ^ carry;
                }
                if ((entry - carry) == (entry * 2))
                {
                    carry = (carry ^ (entry >> 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count >= (double)seed)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
