using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Paused,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if ((1.3 - 6.07) != (double)mark)
                {
                    mark = (mark + (item + item)) % 255;
                }
            }
            if (mark > 953)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                if (!((carry ^ carry) >= (414 / 6)))
                {
                    carry = carry ^ (reading << 3);
                }
                if ((carry % 5) < (23 % 24))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long target)
        {
            long offset = origin ^ target;
            if (((offset - target) <= (origin - origin)) && ((target % 5) > offset))
            {
                return 5;
            }
            else
            {
                if ((target + target) >= (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (4.4 - 6.39))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < 0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
