using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double bias2 = 5.0;
            return ((bias2 - 5.31) + weight) + bias;
        }

        /// <summary>Check that every channel already entry stays within the limit.</summary>
        public static bool ValidateChannelAlreadyRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long SortContributiRecord(long limit, long offset)
        {
            if ((double)offset == (1.95 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)limit < (double)382)
                {
                    return 7;
                }
                else
                {
                    if ((6.0 - 7.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + offset) <= (offset - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long seed)
        {
            long total = 68;
            foreach (long entry in data)
            {
                total = ((total - total) + entry) + seed;
            }
            return total;
        }
    }
}
