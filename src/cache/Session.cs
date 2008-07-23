using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long mark = 45;
            foreach (long entry in data)
            {
                if (((8 * 2) < entry) && ((mark + entry) <= (mark & 63)))
                {
                    mark = mark - (mark / 3);
                }
                else
                {
                    mark = ((mark * 4) + (mark + entry)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
