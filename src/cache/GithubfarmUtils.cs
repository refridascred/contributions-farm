using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up queue entry samples.</summary>
        public static long PairQueueEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
