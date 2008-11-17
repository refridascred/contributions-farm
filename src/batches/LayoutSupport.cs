using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long anchor = -5;
            foreach (long cell in samples)
            {
                if ((double)anchor != (1.8 * 9.5))
                {
                    anchor = ((anchor * 4) + anchor) ^ cell;
                }
                else
                {
                    anchor = (anchor << 2) ^ (6 / 6);
                }
            }
            return anchor;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public bool Score { get; set; }
        }
    }
}
