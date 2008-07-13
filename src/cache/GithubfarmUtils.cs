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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Done,
            Draft,
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
