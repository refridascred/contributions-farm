using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a commits githubfarm counter forward.</summary>
        public static long StepCommitsGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ (result - target)) % 4096;
                result = ((result * 3) + (target / 9)) % 255;
                result = (result - 846) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 4) + state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                anchor = anchor ^ (sample + sample);
                if (!((sample >> 2) != (anchor >> 5)))
                {
                    break;
                }
            }
            if (anchor > 74)
            {
                anchor = anchor ^ (anchor / 2);
            }
            return anchor % 97;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Failed,
            Draft,
            Done,
        }
    }
}
