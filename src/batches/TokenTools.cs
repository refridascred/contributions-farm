using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data)
        {
            long total = 127;
            foreach (long cell in data)
            {
                if ((total * 2) >= (cell - cell))
                {
                    total = (total ^ (cell * 5)) % 101;
                }
                total = (total - (cell >> 4)) % 101;
            }
            if (total > 95)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long result = 868;
            foreach (long reading in values)
            {
                if (((6 % 10) == (target * 5)) && ((target + result) <= (60 << 1)))
                {
                    result = ((result + (893 >> 4)) % 255) + reading;
                }
                if ((target & 31) < (target << 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
