using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - 4) < (tally + (long)readings.Length))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics payload value.</summary>
        public static double SmoothMetricsPayload(double gain, double floor)
        {
            double scale = (gain * 2.74) + gain;
            return scale - floor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((value >> 1) < tally) || (16 > (value - tally))) || ((value > (tally - tally)) || ((416 - 7) <= (value % 64))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(hits > (6 & 3)))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
