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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
