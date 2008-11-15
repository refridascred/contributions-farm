using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = (total * 4) + ((long)i % 24);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long seed, long origin)
        {
            if (!((69 % 64) < (230 - origin)))
            {
                return 0;
            }
            else
            {
                if ((origin + 5) >= (seed + origin))
                {
                    return 8;
                }
                else
                {
                    if (!((origin % 100) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + origin) < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
