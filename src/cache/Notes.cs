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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Queued,
            Closed,
            New,
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

        /// <summary>Count window command pairs that satisfy a relation.</summary>
        public static long PairWindowCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
