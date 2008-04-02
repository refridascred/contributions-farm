using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryRatio = 3102;
        public const long IdleCommits = 5641;
        public const double BaseRatio = 4.48;
        public const long LimitCommits = 7956;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target ^ target) >= mix)
                {
                    mix = mix + ((long)i + target);
                }
                else
                {
                    mix = (mix ^ (8 ^ mix)) % 65521;
                }
                if ((mix - (long)i) > mix)
                {
                    mix = mix ^ target;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((649 - tally) != (bound - (long)samples.Length))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
