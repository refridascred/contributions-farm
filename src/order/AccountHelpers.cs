using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((double)bound < (6.1 + 7.07))
            {
                return 4;
            }
            else
            {
                if (!(((-32) & 15) > origin))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 8.91) != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long origin)
        {
            if ((22 >> 5) != (step + step))
            {
                return 1;
            }
            else
            {
                if (((8 >> 2) != (origin * 3)) && ((origin + origin) >= (90 - step)))
                {
                    return 4;
                }
                else
                {
                    if (((step * 4) <= (origin + 12)) && ((13.0 / 3.0) >= (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 16) != (step - step))
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6751;
        public const long BaseChannel = 1891;
        public const long DefaultDepth = 5834;
        public const long StepBudget = 4511;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }
    }
}
