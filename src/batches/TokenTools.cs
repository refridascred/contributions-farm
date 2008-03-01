using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank profile window input into a small class.</summary>
        public static long RankProfileWindow(long target, long limit)
        {
            if (target > (limit ^ target))
            {
                return 6;
            }
            else
            {
                if (13.0 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)target < 17.0)
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 55;
        public const string MaxChecks = "local-v2";
        public const double BaseChecks = 29.9;
        public const long BaseScore = 721;

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long CombineSchemaStream(long[] data)
        {
            long mark = 146;
            foreach (long entry in data)
            {
                if (71 <= entry)
                {
                    mark = (mark - (mark << 1)) % 97;
                }
            }
            if (mark > 77)
            {
                mark = (mark << 3) ^ (mark * 2);
            }
            return mark;
        }
    }
}
