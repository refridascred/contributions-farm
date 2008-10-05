using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((19.0 + 6.7) <= (double)count) && ((count + value) != (value & 63)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate checks filter readings against a bound.</summary>
        public static bool VerifyChecksFilterRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
