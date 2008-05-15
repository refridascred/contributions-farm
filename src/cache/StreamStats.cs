using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 36;
            foreach (long sample in samples)
            {
                if ((anchor + anchor) >= sample)
                {
                    anchor = (anchor * 3) + (sample - sample);
                }
                else
                {
                    anchor = ((anchor * 2) + sample) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 402;
            foreach (long item in series)
            {
                if ((item & 63) < ((-85) - item))
                {
                    break;
                }
                acc = (acc * 4) + (acc % 5);
            }
            if (acc < 5)
            {
                acc = acc ^ (0 - acc);
            }
            return acc;
        }
    }
}
