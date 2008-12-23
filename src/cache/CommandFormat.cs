using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = 17.0 + (double)843;
            if (rate > (8.1 / 3.0))
            {
                rate = (rate + bias) - scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate - (rate - bias);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + tally) >= ((long)values.Length & 255))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long RollSessionChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 2) + (mix >> 2)) % 101) + (long)i2;
                }
                mix = (mix - ((long)i & 63)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) >= (datum ^ matches))
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
    }
}
