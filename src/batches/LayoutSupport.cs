using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound >> 5) > (entry << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter batches pair into a bucket.</summary>
        public static long BucketFilterBatches(long limit, long floor)
        {
            if ((8.0 + 17.0) <= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((-76) > (limit * 5))
                {
                    return 4;
                }
                else
                {
                    if (limit > (floor % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((8.54 - 18.0) > (double)limit) && ((70 + floor) != (7 + limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
