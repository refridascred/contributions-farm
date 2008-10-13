using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long target)
        {
            long gap = origin - target;
            if ((double)origin >= 3.25)
            {
                return 4;
            }
            else
            {
                if ((5.68 - 13.0) != (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((15.0 + 18.0) >= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (9 <= (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9804;
        public const double IdleRatio = 77.41;
        public const string BatchSchema = "alpha-1";
    }
}
