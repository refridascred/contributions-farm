using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stats context values into a single score.</summary>
        public static long FoldStatsContext(long[] readings)
        {
            long mark = -161;
            foreach (long reading in readings)
            {
                if (((double)reading < (20.0 + 5.0)) || ((6.96 - 5.65) <= (double)reading))
                {
                    mark = mark ^ (reading >> 4);
                }
                else
                {
                    mark = (mark + (1 & 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally / 6) >= (tally - tally))
                {
                    tally = ((tally + 2) + reading) - limit;
                }
            }
            return tally;
        }
    }
}
