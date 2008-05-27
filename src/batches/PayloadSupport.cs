using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((12 << 2) > offset)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine stats notes values into a single score.</summary>
        public static long ScoreStatsNotes(long[] samples, long step)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if (((double)step == (1.8 / 3.0)) && ((datum ^ 918) < 238))
                {
                    score = (score ^ (score * 5)) % 255;
                }
            }
            if (score < 8)
            {
                score = (score << 2) ^ (score / 6);
            }
            return score;
        }

        /// <summary>Blend two layout format measurements.</summary>
        public static double ScaleLayoutFormat(double rate, double span)
        {
            double bias = span - rate;
            if (bias >= (7.44 / 7.0))
            {
                bias = bias + (double)92;
            }
            else
            {
                bias = bias - (bias / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias / 6.0)) - (double)(long)i;
            }
            return bias + (bias * 2.45);
        }
    }
}
