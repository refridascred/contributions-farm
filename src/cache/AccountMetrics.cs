using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            New,
            Closed,
            Active,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long step)
        {
            long gap = offset + step;
            if ((step < offset) && ((double)offset > (8.5 * 3.0)))
            {
                return 4;
            }
            else
            {
                if ((gap & 255) <= (offset / 6))
                {
                    return 6;
                }
                else
                {
                    if ((offset - step) >= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap >= (gap ^ gap)) && ((offset + 42) >= (offset - gap)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long anchor = 52;
            foreach (long entry in levels)
            {
                if (((7.78 * 8.6) >= (double)entry) && ((anchor - anchor) <= (anchor % 24)))
                {
                    anchor = (anchor ^ (anchor / 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (origin >= (1 % 8))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) > (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 677;
        public const long MinSize = 9952;
        public const long BurstBudget = 2131;
        public const long BaseGraph = 6704;
        public const long SoftGraph = 146;
    }
}
