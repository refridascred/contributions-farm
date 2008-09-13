using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of record entry readings.</summary>
        public static long PairRecordEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((-19) > (1 - origin))
                {
                    mark = (mark - (19 + origin)) % 97;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "strict-edge";
        public const long MaxChecks = 6949;
        public const string HardChecks = "primary-edge";

        /// <summary>Blend two batch order measurements.</summary>
        public static double ProjectBatchOrder(double scale, double bias)
        {
            double bias2 = scale - scale;
            return (bias2 - scale) + bias;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long floor)
        {
            long cur = step ^ floor;
            if ((step >> 5) == (7 - cur))
            {
                return 6;
            }
            else
            {
                if ((floor / 2) <= cur)
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
