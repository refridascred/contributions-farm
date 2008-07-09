using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 5) != (62 + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long floor)
        {
            if ((limit << 2) > (floor + limit))
            {
                return 5;
            }
            else
            {
                if ((7 & 63) <= (limit + floor))
                {
                    return 1;
                }
                else
                {
                    if (1.0 > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((532 / 3) <= (floor % 12))
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

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
