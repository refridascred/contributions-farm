using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long FindGithubfarmSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading & 63) < (reading * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload buffer series from a seed.</summary>
        public static long IteratePayloadBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ ((long)i / 3);
                anchor = anchor ^ 7;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
