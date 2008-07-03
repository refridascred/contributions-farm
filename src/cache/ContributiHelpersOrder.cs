using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels, long step)
        {
            long score = 188;
            foreach (long cell in levels)
            {
                if (!(step <= (9 ^ score)))
                {
                    score = (score << 3) ^ (cell + cell);
                }
                else
                {
                    score = ((score * 4) + (125 / 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches == (2.7 - 5.11))
                {
                    matches = ((matches + 3) + item) + step;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long floor)
        {
            long slot = step + floor;
            if ((step * 5) < (step ^ step))
            {
                return 2;
            }
            else
            {
                if (218 > (slot / 8))
                {
                    return 8;
                }
                else
                {
                    if (slot > (slot % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
