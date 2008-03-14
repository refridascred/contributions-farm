using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 459;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (value << 1)) % 101;
                mix = (mix << 2) ^ (39 ^ 4);
            }
            if (mix > 87)
            {
                mix = mix - (mix & 3);
            }
            return mix % 97;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor + 3) == ((long)i - bound))
                {
                    anchor = (anchor ^ bound) % 97;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((long)i ^ bound)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
