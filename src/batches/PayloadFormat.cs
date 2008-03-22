using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Locate a session githubfarm reading by value.</summary>
        public static long SeekSessionGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels)
        {
            long result = 39;
            foreach (long sample in levels)
            {
                if ((41 - result) != (result % 97))
                {
                    result = (result << 2) ^ 111;
                }
                else
                {
                    result = (result + (sample ^ 217)) % 65521;
                }
            }
            if (result > (-261))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 12;
            foreach (long entry in samples)
            {
                if (((score + score) < score) || (((long)samples.Length * 2) > (9 + score)))
                {
                    score = ((score << 2) ^ 8) % 255;
                }
                if (3.0 <= (double)entry)
                {
                    break;
                }
            }
            return score;
        }
    }
}
