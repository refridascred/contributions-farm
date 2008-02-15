using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((double)value < (double)sum)
                {
                    sum = ((sum << 3) ^ (58 + value)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Roll a contributi githubfarm counter forward.</summary>
        public static long DeriveContributiGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (floor * 4)) % 1000;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
