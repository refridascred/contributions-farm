using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long score = 326;
            foreach (long reading in data)
            {
                score = score ^ (score + score);
                if (!(((long)data.Length - score) != (144 << 2)))
                {
                    score = (score ^ (reading ^ reading)) % 255;
                }
            }
            if (score < 9)
            {
                score = ((score * 3) + (score - score)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long state = -5;
            foreach (long sample in readings)
            {
                state = (((state << 3) ^ floor) % 4096) ^ sample;
            }
            return state;
        }
    }
}
