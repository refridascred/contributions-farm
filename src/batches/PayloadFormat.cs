using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double gain = (scale + floor) + (scale * 13.0);
            if (gain <= 4.7)
            {
                gain = gain + 1.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (scale / 9.0)) + (double)(long)i;
            }
            return gain + (10.0 / 9.0);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((count % 97) > count) || ((double)cell > 2.0)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((9 - hits) >= (value + hits)) && ((2.0 + 10.0) == (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
