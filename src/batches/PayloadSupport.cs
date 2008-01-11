using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values, long offset)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                if (((-126) >> 5) < (long)values.Length)
                {
                    mark = ((mark << 3) ^ mark) + cell;
                }
                if (((6.65 * 5.4) >= (double)mark) && ((double)offset >= (1.3 * 12.0)))
                {
                    mark = (mark ^ (56 * 4)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Locate a account schema reading by value.</summary>
        public static long LookupAccountSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window githubfarm readings against a rule.</summary>
        public static long TallyWindowGithubfarmOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length << 3) >= step)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
