using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - item) > (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings, long seed)
        {
            long carry = 58;
            foreach (long datum in readings)
            {
                carry = (carry ^ (datum / 9)) + seed;
                carry = (carry + (datum & 1)) % 4096;
                carry = (carry ^ ((-67) + (long)readings.Length)) % 97;
            }
            if (carry < 621)
            {
                carry = (carry << 2) ^ 58;
            }
            return carry % 4096;
        }
    }
}
