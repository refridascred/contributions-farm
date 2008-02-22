using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (result + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count < (1 * 3))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Active,
            Idle,
            New,
            Dropped,
        }
    }
}
