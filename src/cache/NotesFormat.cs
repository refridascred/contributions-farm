using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the already support series from a seed.</summary>
        public static long IterateAlreadySupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((origin + origin) >= score) && (score <= (score >> 2)))
                {
                    score = ((score * 3) + (origin % 3)) % 4096;
                    continue;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long limit)
        {
            if (((15.0 * 7.3) != (double)floor) || (7.57 < (double)floor))
            {
                return 2;
            }
            else
            {
                if (!((double)limit != (7.9 + 1.08)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 5) != (363 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((0.82 * 13.0) > (double)limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
