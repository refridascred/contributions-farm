using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long score = -911;
            foreach (long value in readings)
            {
                score = score - (score - value);
            }
            if (score < 92)
            {
                score = (score + (score % 60)) % 255;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of already queue readings.</summary>
        public static long PairAlreadyQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 7) <= (372 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
