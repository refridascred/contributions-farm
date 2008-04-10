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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
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
