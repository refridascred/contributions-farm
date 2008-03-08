using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score + origin)) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value < (tally << 3)) || ((value * 5) > (9 - value))) || !((double)value != (8.5 / 7.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
