using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long CountPayloadChannelMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((floor * 3) > (item % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
