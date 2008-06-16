using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long limit)
        {
            long slot = step + limit;
            if ((step * 4) != (7 / 4))
            {
                return 4;
            }
            else
            {
                if ((slot - step) < (39 ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot - slot) >= slot)
                        {
                            return 3;
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
