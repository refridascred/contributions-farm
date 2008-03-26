using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up counter graph samples.</summary>
        public static long PairCounterGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 2) >= (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Pending,
            Ready,
        }
    }
}
