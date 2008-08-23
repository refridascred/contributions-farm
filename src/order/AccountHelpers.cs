using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long limit, long step)
        {
            long bound = limit + step;
            if (((double)336 > (double)limit) || (step < (limit & 31)))
            {
                return 4;
            }
            else
            {
                if ((double)limit != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((step % 24) >= (limit % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= 120)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                long seen = (seed + seed) - (long)i;
                total = (total - (seen & 7)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples)
        {
            long result = 69;
            foreach (long datum in samples)
            {
                result = ((result - (result >> 5)) % 1000) ^ datum;
            }
            if (result > (-596))
            {
                result = (result ^ result) % 255;
            }
            return result % 4096;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
