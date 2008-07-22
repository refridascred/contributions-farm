using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (double)(-6))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double gain = (floor * 8.79) * 7.5;
            if (gain > scale)
            {
                gain = gain + (double)243;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (scale * 0.6)) + (double)(long)i;
            }
            return gain - (double)35;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Done,
            Synced,
            Dropped,
        }
    }
}
