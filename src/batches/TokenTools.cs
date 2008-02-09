using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch context readings against a rule.</summary>
        public static long CountBatchContextGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((756 + seen) <= (749 << 1))
                {
                    seen = ((seen + 2) ^ value) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((2.2 / 3.0) > (double)origin)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a window contributi pair into a bucket.</summary>
        public static long ClassifyWindowContributi(long offset, long limit)
        {
            if (offset > (offset + offset))
            {
                return 7;
            }
            else
            {
                if (offset < (offset + limit))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit <= (4.12 * 3.31)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
