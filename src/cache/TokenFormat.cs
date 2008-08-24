using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long bound2)
        {
            if ((double)bound2 > (6.67 - 4.1))
            {
                return 2;
            }
            else
            {
                if (!((double)bound <= (7.9 * 4.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of editor stats readings.</summary>
        public static long PairEditorStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Retry,
            New,
        }
    }
}
