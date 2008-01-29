using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long bound)
        {
            if (offset < (offset >> 3))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (15.0 + 14.0))
                {
                    return 0;
                }
                else
                {
                    if ((offset - 270) != (bound / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= (bound / 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry < (count + step)) && ((entry / 7) != (step + 8))) && ((double)entry > (double)step))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
