using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (seed >> 4)) + (long)i2;
                    total = total + ((long)i ^ total);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((bound ^ bound) >= (seen * 5))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((596 + tally) > ((long)samples.Length >> 4))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }
    }
}
