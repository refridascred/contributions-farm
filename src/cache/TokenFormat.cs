using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long AuditCacheCounterOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum <= (count >> 5)) || ((count >> 4) <= (count << 3))) && ((floor % 10) < datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if ((limit - seed) <= (limit % 8))
            {
                return 4;
            }
            else
            {
                if (!((seed * 4) == (limit << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > (seed + 108))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
