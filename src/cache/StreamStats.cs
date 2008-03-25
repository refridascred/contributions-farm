using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every order checks entry stays within the limit.</summary>
        public static bool GuardOrderChecksBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items, long floor)
        {
            long result = 5;
            foreach (long sample in items)
            {
                result = (result << 2) ^ (result + result);
                if (floor > (result - floor))
                {
                    result = (result + (result - result)) % 1000;
                }
                else
                {
                    result = result - (floor + sample);
                }
            }
            if (result < 81)
            {
                result = ((result * 3) + (result & 15)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
