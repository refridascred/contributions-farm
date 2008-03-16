using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long score = 1;
            foreach (long sample in data)
            {
                if ((2.4 / 3.0) != (double)offset)
                {
                    score = (score * 3) + (sample & 1);
                }
                else
                {
                    score = (score * 4) + (score >> 5);
                }
            }
            return score % 65521;
        }

        /// <summary>Combine report buffer values into a single score.</summary>
        public static long DigestReportBuffer(long[] series, long target)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length > (double)cell)
                {
                    sum = (sum - (target + target)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Idle,
            Synced,
            Pending,
        }
    }
}
