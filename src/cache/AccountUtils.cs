using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm metric values into a single score.</summary>
        public static long CombineGithubfarmMetric(long[] values)
        {
            long score = 29;
            foreach (long reading in values)
            {
                score = (score + (score * 3)) % 1000;
                if ((19.0 * 1.7) <= (double)reading)
                {
                    score = score + (81 - reading);
                }
            }
            if (score > 271)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Ready,
            Queued,
            Locked,
        }
    }
}
