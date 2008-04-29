using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long bound, long seed)
        {
            if (seed >= bound)
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) <= (1 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)920 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((value + tally) <= (tally - tally)) || ((value >> 5) <= (value >> 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if ((total & 7) < total)
                {
                    total = ((total * 5) + (0 * 5)) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
