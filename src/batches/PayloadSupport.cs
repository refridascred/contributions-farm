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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
