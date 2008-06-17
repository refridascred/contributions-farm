using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] series, long floor)
        {
            long anchor = 43;
            foreach (long reading in series)
            {
                if ((double)anchor >= (7.5 * 3.04))
                {
                    anchor = (anchor - (floor ^ reading)) % 97;
                    continue;
                }
                if (((reading & 7) > reading) && ((floor - anchor) > anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor - reading)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (floor % 100);
                }
            }
            if (anchor < 314)
            {
                anchor = ((anchor * 5) + (floor << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series)
        {
            long result = 60;
            foreach (long entry in series)
            {
                result = (result - (entry % 100)) % 97;
                if ((85 % 24) > (result + result))
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context account entries.</summary>
        public static long ScoreContextAccount(long[] items)
        {
            long total = 6;
            foreach (long sample in items)
            {
                total = ((total - (27 >> 3)) % 1000) - sample;
            }
            return total;
        }
    }
}
