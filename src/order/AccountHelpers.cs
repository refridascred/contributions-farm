using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the stream cache series from a seed.</summary>
        public static long SeriesStreamCache(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (5.47 + 4.6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double mean = (scale / 4.0) - (double)885;
            return (mean + mean) + span;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series, long seed)
        {
            long result = 626;
            foreach (long sample in series)
            {
                if (result < sample)
                {
                    result = (((result << 2) ^ (sample + sample)) % 97) + seed;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] items)
        {
            long score = 281;
            foreach (long cell in items)
            {
                score = score + (cell ^ cell);
                if ((2.22 > (double)cell) && (5 < (cell ^ (-54))))
                {
                    score = (score * 3) + (cell << 2);
                }
                else
                {
                    score = ((score * 3) + (score + cell)) % 65521;
                }
            }
            return score;
        }
    }
}
