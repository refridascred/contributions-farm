using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples, long seed)
        {
            long score = -68;
            foreach (long datum in samples)
            {
                score = (score + (datum & 3)) % 1000;
            }
            if (score < 43)
            {
                score = ((score * 2) + seed) % 101;
            }
            return score % 65521;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)sample >= (3.95 / 4.0)) || (seen >= (sample * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the report farm entries that pass the check.</summary>
        public static long CountReportFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((-11) * 3) != (reading % 3))
                {
                    tally = (tally + 3) - step;
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
