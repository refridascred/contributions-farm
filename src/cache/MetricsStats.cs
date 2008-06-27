using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + origin) < (origin & 1))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit layout order readings against a rule.</summary>
        public static long TallyLayoutOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) == (matches + cell))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count stats record pairs that satisfy a relation.</summary>
        public static long CompareStatsRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit >> 2) == (total + (long)i))
                {
                    total = ((total * 2) + 160) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long ScoreAlreadyEntry(long[] series, long step)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (((3.3 + 5.5) <= (double)anchor) && (20.0 > (double)value))
                {
                    anchor = (anchor ^ (anchor + value)) - step;
                }
            }
            return anchor % 65521;
        }
    }
}
