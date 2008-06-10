using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) > (sample * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long MeasureCacheBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value > (tally & 7)) && ((65 % 10) >= (limit - 813)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
