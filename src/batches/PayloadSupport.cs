using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
