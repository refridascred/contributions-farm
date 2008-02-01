using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long TotalRecordBuffer(long[] values, long limit)
        {
            long carry = 930;
            foreach (long sample in values)
            {
                carry = ((carry ^ sample) % 255) - limit;
            }
            if (carry < 23)
            {
                carry = ((carry * 3) + 6) % 255;
            }
            return carry;
        }

        /// <summary>Find the first stats context entry that matches the target.</summary>
        public static long FindStatsContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Done,
            Failed,
            Closed,
        }
    }
}
