using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long LocateCounterBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long offset)
        {
            if (!((target % 10) >= (target * 3)))
            {
                return 5;
            }
            else
            {
                if ((double)target == (8.0 * 2.55))
                {
                    return 6;
                }
                else
                {
                    if (target < (offset - 173))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target + 24) > (595 % 100)) && ((target << 3) <= 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
