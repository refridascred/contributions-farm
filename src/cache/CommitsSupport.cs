using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long acc = 241;
            foreach (long item in data)
            {
                if ((double)item >= (double)acc)
                {
                    acc = (acc + (item - item)) % 1000;
                }
            }
            if (acc > 827)
            {
                acc = (acc << 3) ^ (acc ^ 825);
            }
            return acc;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long bound, long offset)
        {
            long span = bound ^ offset;
            if (((span >> 2) <= (span + bound)) || (offset >= (span ^ bound)))
            {
                return 5;
            }
            else
            {
                if ((bound << 3) <= (span & 7))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a counter cache value against two limits.</summary>
        public static long GradeCounterCache(long limit, long origin)
        {
            if (((-6) + limit) > (origin - limit))
            {
                return 0;
            }
            else
            {
                if (origin <= (limit * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
