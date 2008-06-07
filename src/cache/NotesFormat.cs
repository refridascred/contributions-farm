using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            long delta = step - offset;
            if ((offset + delta) < (106 + offset))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) == (step + delta))
                {
                    return 6;
                }
                else
                {
                    if (!((2.24 + 7.92) == (double)delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta * 5) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            long span = offset + bound;
            if ((span ^ offset) > (span + 159))
            {
                return 6;
            }
            else
            {
                if ((2.5 * 9.66) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((477 <= offset) || ((bound % 100) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
