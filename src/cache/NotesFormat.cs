using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
