using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long limit)
        {
            if (limit >= (step - limit))
            {
                return 8;
            }
            else
            {
                if (9.36 <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + step) == (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 ^ limit) != (step + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry already series from a seed.</summary>
        public static long RollEntryAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = total + (total & 63);
                if ((limit + 6) < limit)
                {
                    total = ((total * 2) + (long)i) % 1000;
                    total = total ^ (total ^ 242);
                }
                else
                {
                    total = total - ((long)i - total);
                    total = total ^ (total - total);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 741;
        public const long BaseScore = 9271;
        public const string IdleTimeout = "local";
        public const double BatchChannel = 17.72;
    }
}
