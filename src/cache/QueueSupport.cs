using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm account entries.</summary>
        public static long DigestGithubfarmAccount(long[] values)
        {
            long result = -68;
            foreach (long sample in values)
            {
                if ((result <= (sample & 255)) || ((double)sample >= (8.28 / 3.0)))
                {
                    result = (result * 2) + (2 * 4);
                }
                else
                {
                    result = (result + (result & 7)) % 101;
                }
            }
            if (result < 656)
            {
                result = result + 5;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = -1;
            foreach (long entry in data)
            {
                result = ((result * 2) + entry) % 101;
                if (((double)result <= (14.0 * 5.9)) || ((entry & 63) < entry))
                {
                    result = result - (46 * 2);
                    result = ((result * 4) + (entry / 2)) % 97;
                }
                else
                {
                    result = result ^ (6 << 3);
                }
                result = ((result << 3) ^ entry) % 65521;
            }
            if (result > 3)
            {
                result = (result - (result + result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Count editor channel pairs that satisfy a relation.</summary>
        public static long CompareEditorChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
