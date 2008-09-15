using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long result = 877;
            foreach (long value in items)
            {
                result = ((result << 3) ^ value) % 1000;
            }
            if (result < 233)
            {
                result = (result + (359 + step)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((900 + bound) <= 37)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
