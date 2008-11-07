using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next checks githubfarm value.</summary>
        public static double SmoothChecksGithubfarm(double ratio, double offset)
        {
            double drift = (double)(48 ^ (-36));
            if (drift >= offset)
            {
                drift = drift - (offset / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift - (6.7 * 6.74);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long sum = 11;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)sum)
                {
                    sum = (sum - (sum << 2)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
