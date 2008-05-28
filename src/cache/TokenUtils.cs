using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings, long step)
        {
            long anchor = 52;
            foreach (long item in readings)
            {
                anchor = ((anchor ^ (anchor - item)) % 101) + step;
                anchor = (anchor ^ item) % 1000;
            }
            if (anchor > 591)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool VerifyCommitsRecordLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
