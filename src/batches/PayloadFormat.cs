using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches >= (long)data.Length)
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long score = 39;
            foreach (long reading in series)
            {
                if (((score ^ 4) == (reading + origin)) || ((origin / 8) >= (reading * 4)))
                {
                    score = score + 67;
                }
                if ((reading * 3) < (origin + (-394)))
                {
                    break;
                }
            }
            if (score > 78)
            {
                score = score ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((floor >> 1) >= floor))
                {
                    mix = (mix * 4) + floor;
                }
                else
                {
                    mix = (mix + (floor + 448)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Synced,
            Queued,
            Idle,
        }
    }
}
