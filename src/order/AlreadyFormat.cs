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

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Done,
            Active,
        }
    }
}
