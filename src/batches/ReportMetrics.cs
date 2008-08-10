using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples, long offset)
        {
            long result = 21;
            foreach (long sample in samples)
            {
                result = result - (sample * 3);
                if (result <= offset)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Locate a checks schema reading by value.</summary>
        public static long FindChecksSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
