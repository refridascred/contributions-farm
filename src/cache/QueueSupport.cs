using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2742;
        public const double MaxRoute = 68.18;
        public const long WindowRoute = 5155;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long bound)
        {
            long mix = 43;
            foreach (long reading in series)
            {
                if (((double)reading <= (8.18 / 4.0)) && ((double)bound <= (double)reading))
                {
                    mix = (mix * 5) + reading;
                }
                if ((bound - bound) < mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long TallyStatsFilterHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally >= (floor & 15))
                {
                    tally = (tally + 2) + cell;
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
