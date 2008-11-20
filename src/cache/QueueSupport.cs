using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route record input into a small class.</summary>
        public static long RankRouteRecord(long limit, long step)
        {
            if ((double)step > 1.3)
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((limit / 6) <= (step & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the metric support series from a seed.</summary>
        public static long DeriveMetricSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                long tally = result >> 4;
                if ((limit + 88) >= tally)
                {
                    tally = ((tally * 5) + (result / 4)) % 4096;
                    break;
                }
                else
                {
                    result = (result + (result * 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftLevel = 9015;
        public const double MaxDepth = 83.81;
        public const long RetryReport = 1555;
    }
}
