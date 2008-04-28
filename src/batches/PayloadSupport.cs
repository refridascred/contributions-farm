using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 18) == (seen * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
