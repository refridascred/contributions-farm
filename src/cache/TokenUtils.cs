using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long AuditNotesAccountHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seen) <= (seen >> 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long step)
        {
            if ((limit & 1) > (limit - (-41)))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) >= (limit + step))
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit * 3))
                    {
                        return 3;
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
