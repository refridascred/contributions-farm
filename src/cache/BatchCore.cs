using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)score == (6.0 + 20.0))
                {
                    score = (score - ((long)i * 3)) % 65521;
                }
                else
                {
                    score = score - (score + step);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + (score & 1)) % 255) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 1008;
        public const double StepContributi = 19.77;
        public const long DefaultRatio = 7969;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches >= (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                double load = 14.0;
                if (((double)(-574) < (load * 20.0)) && ((99 << 1) < (limit << 3)))
                {
                    load = load - load;
                    load = load - load;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
