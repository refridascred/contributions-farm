using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session notes readings against a rule.</summary>
        public static long TallySessionNotesMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (9.2 / 6.0))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                double mean = (double)(target >> 5);
                if (mean >= (mean / 9.0))
                {
                    mix = (mix * 3) + target;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two payload entry measurements.</summary>
        public static double ProjectPayloadEntry(double bias, double offset)
        {
            double scale = 2.89;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (offset / 9.0)) - (double)(long)i) - bias;
            }
            return scale + (scale / 4.0);
        }
    }
}
