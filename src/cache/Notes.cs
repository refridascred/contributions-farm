using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            if ((target / 8) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit == (2.16 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (7.92 + 19.0))
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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long step)
        {
            long edge = limit ^ step;
            if (edge <= limit)
            {
                return 1;
            }
            else
            {
                if (((7.78 - 7.3) <= (double)limit) && ((limit ^ step) < step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long FoldChannelRoute(long[] samples, long offset)
        {
            long anchor = 33;
            foreach (long cell in samples)
            {
                anchor = (anchor + (2 - cell)) - offset;
                anchor = ((anchor * 2) + (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a githubfarm payload reading by value.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
