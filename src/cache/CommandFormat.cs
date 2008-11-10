using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long limit)
        {
            long step = target - limit;
            if ((double)target <= 15.0)
            {
                return 4;
            }
            else
            {
                if (!((target + 241) == (step / 4)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long limit)
        {
            long cur = bound + limit;
            if ((limit & 7) != (cur + limit))
            {
                return 1;
            }
            else
            {
                if (((cur & 31) <= (limit * 5)) || ((8 + cur) > cur))
                {
                    return 5;
                }
                else
                {
                    if (((cur & 15) < (cur + limit)) || ((limit / 5) > 831))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound ^ limit) != (cur ^ bound)))
                        {
                            return 4;
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
