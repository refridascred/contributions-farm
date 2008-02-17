using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long step2)
        {
            long slot = step - step2;
            if (!((slot - step) <= slot))
            {
                return 5;
            }
            else
            {
                if ((double)slot > (6.7 * 4.44))
                {
                    return 4;
                }
                else
                {
                    if ((step2 << 2) <= (step2 & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step <= (4.0 - 9.16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
