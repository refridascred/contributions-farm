using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double scale = (double)(99 + 38);
            if (scale <= rate)
            {
                scale = (scale + (double)0) - offset;
            }
            return scale + (double)(-5);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long state = -262;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (state - step)) ^ value;
                if (!(9 < (state / 7)))
                {
                    state = (state ^ step) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            if (!((limit * 4) < (limit / 4)))
            {
                return 5;
            }
            else
            {
                if (((limit >> 5) == (5 % 3)) && ((floor + floor) > floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + 6) != (floor - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= floor) && ((limit - floor) < (floor - limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
