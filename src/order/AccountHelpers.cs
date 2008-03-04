using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                mark = ((mark * 3) + mark) + entry;
            }
            return mark;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 3) + 417;
                if ((sum ^ (long)i) <= (sum * 4))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Rank account cluster input into a small class.</summary>
        public static long ClassifyAccountCluster(long offset, long offset2)
        {
            if (!(offset2 > (offset % 8)))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if ((offset2 - offset) == (offset + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
