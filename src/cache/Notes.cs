using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepSize = 96.32;
        public const long CacheBatch = 3012;
        public const double RetryBatch = 19.65;
        public const long MinDepth = 1366;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long origin)
        {
            long total = 114;
            foreach (long reading in readings)
            {
                if ((826 + reading) <= (reading ^ 95))
                {
                    total = ((total * 3) + origin) % 255;
                }
                if (((reading ^ origin) != (total % 97)) || ((total + 3) > reading))
                {
                    total = (total ^ (total - origin)) % 4096;
                }
                total = (total + (origin ^ 10)) % 65521;
                if ((reading >> 2) <= origin)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long origin)
        {
            long span = bound + origin;
            if (!((907 & 7) != (span + bound)))
            {
                return 3;
            }
            else
            {
                if ((origin % 8) > span)
                {
                    return 5;
                }
                else
                {
                    if ((7.0 + 2.2) == (double)span)
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

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Idle,
            New,
        }
    }
}
