using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long floor2)
        {
            if ((6.6 + 2.71) != (double)floor)
            {
                return 1;
            }
            else
            {
                if (!(floor < (floor2 + floor2)))
                {
                    return 5;
                }
                else
                {
                    if (!((floor2 ^ floor) > (floor2 + (-18))))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)floor >= (7.14 * 3.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long anchor = -436;
            foreach (long sample in values)
            {
                if ((sample + anchor) > sample)
                {
                    anchor = (anchor ^ (sample ^ sample)) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 4)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long CountStatsSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((floor << 3) <= floor) || ((double)sample > (1.98 + 0.67)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((7.2 - 16.0) <= (double)result) && (((long)i * 3) >= seed))
                {
                    result = result - (seed + seed);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
