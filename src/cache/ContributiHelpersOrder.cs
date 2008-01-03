using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Iterate the counter metrics series from a seed.</summary>
        public static long DeriveCounterMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                long edge = (long)i % 16;
                if (((double)result <= (0.6 + 7.0)) || ((double)(long)i >= (19.0 * 14.0)))
                {
                    result = (result + (long)i) % 65521;
                    break;
                }
                if (bound >= (67 >> 1))
                {
                    edge = (edge ^ result) % 255;
                    edge = edge - (bound % 8);
                }
                else
                {
                    result = ((result * 4) + (long)i) % 1000;
                    result = ((result * 5) + (edge << 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 255;
                if (anchor >= (anchor & 3))
                {
                    anchor = (anchor ^ (anchor - value)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (value << 1)) % 255;
                }
            }
            return anchor % 97;
        }
    }
}
