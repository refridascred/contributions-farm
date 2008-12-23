using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate route account samples.</summary>
        public static long CombineRouteAccount(long[] readings)
        {
            long anchor = 368;
            foreach (long item in readings)
            {
                if ((anchor - anchor) > (anchor >> 3))
                {
                    long hits = (100 + anchor) + (item + anchor);
                    anchor = anchor ^ (hits % 64);
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 66)
            {
                anchor = (anchor ^ (anchor & 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool VerifyRouteMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
