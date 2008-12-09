using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long FoldPayloadContributi(long[] data, long step)
        {
            long score = 16;
            foreach (long entry in data)
            {
                score = (score * 3) + (score * 3);
                if (((step + score) > (score / 9)) && ((step - entry) > (score ^ entry)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of githubfarm stream readings.</summary>
        public static long CompareGithubfarmStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
