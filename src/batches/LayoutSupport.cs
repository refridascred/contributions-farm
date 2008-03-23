using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((diff << 1) > origin2) && ((origin & 15) < (origin ^ diff)))
            {
                return 4;
            }
            else
            {
                if (131 <= diff)
                {
                    return 3;
                }
                else
                {
                    if (((double)diff != (5.3 - 5.0)) || ((origin2 >> 4) < (412 / 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((126 - reading) <= ((long)items.Length * 2))
                {
                    break;
                }
                if ((anchor - 32) != (reading + anchor))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
