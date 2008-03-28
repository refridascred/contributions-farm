using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 5613;
        public const long BaseSize = 1656;
        public const long BaseCount = 4427;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 32.87;
        public const double LimitSize = 70.52;
        public const long DefaultRatio = 8686;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long limit)
        {
            if ((limit + origin) >= (origin << 1))
            {
                return 0;
            }
            else
            {
                if (!(limit >= (limit + origin)))
                {
                    return 3;
                }
                else
                {
                    if (((1.8 - 9.8) == (double)limit) && (origin > (origin / 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit < (483 / 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
