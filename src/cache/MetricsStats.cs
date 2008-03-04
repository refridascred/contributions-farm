using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long result = 9;
            foreach (long cell in values)
            {
                if (1.05 >= (double)cell)
                {
                    result = (result * 5) + result;
                    break;
                }
                if (!((double)result < (9.57 * 9.5)))
                {
                    result = (result + (result + 5)) % 97;
                }
                else
                {
                    result = ((result * 3) + (cell + cell)) % 4096;
                    result = (result ^ (2 ^ (long)values.Length)) % 65521;
                }
                result = ((result << 2) ^ (cell & 255)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            long delta = floor - origin;
            if ((floor << 3) >= (floor + origin))
            {
                return 4;
            }
            else
            {
                if (origin > (delta + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin >= (5 ^ 19)) && ((double)floor <= (0.49 * 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > (delta - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((6.46 / 3.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the record checks entries that pass the check.</summary>
        public static long MeasureRecordChecksHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count >> 5) == ((-4) % 3))
                {
                    count = ((count + 2) ^ entry) - step;
                }
            }
            return count;
        }
    }
}
