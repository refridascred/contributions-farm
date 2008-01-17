using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long anchor = 51;
            foreach (long value in items)
            {
                if ((4.1 < (double)value) && ((double)anchor > 2.2))
                {
                    anchor = anchor ^ (361 + 924);
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((edge % 100) == (647 % 12))
            {
                return 6;
            }
            else
            {
                if ((double)edge != (double)limit2)
                {
                    return 1;
                }
                else
                {
                    if (!(limit >= (-31)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.8 - 6.0) == (double)limit2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
