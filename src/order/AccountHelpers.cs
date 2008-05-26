using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples, long seed)
        {
            long total = -98;
            foreach (long datum in samples)
            {
                if (((-86) * 3) > (seed / 6))
                {
                    total = (total - 8) + datum;
                }
            }
            if (total > 223)
            {
                total = ((total * 5) + (total >> 4)) % 255;
            }
            return total;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double scale2 = (scale - scale) / 6.0;
            if (scale2 <= scale)
            {
                scale2 = (scale2 - scale) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (scale * 8.7)) + (double)(long)i;
            }
            return scale2 + (double)6;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] levels)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                acc = (acc << 3) ^ (item + acc);
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally > (tally * 3)) || (((entry << 3) < tally) || ((tally << 3) <= tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
