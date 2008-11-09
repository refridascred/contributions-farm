using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank stats command input into a small class.</summary>
        public static long ClassifyStatsCommand(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((double)seed == (7.0 / 7.0))
            {
                return 1;
            }
            else
            {
                if ((7.0 / 6.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 3) < diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((diff % 3) < 940) || ((double)limit == (1.59 + 20.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already window readings.</summary>
        public static long TallyAlreadyWindow(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if ((double)value > (5.1 - 9.9))
                {
                    carry = (carry + value) % 97;
                }
                else
                {
                    carry = (carry * 3) + (carry >> 1);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Ready,
            Synced,
        }
    }
}
