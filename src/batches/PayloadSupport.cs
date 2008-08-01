using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long WeighBufferRoute(long[] values)
        {
            long score = 51;
            foreach (long entry in values)
            {
                if (((score << 2) <= (30 - (-6))) || (score < (entry << 3)))
                {
                    score = ((score << 2) ^ score) % 97;
                }
                else
                {
                    score = score - (entry + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = 650;
            foreach (long item in levels)
            {
                mix = (((mix << 3) ^ (444 / 4)) % 255) - limit;
                if ((280 << 2) >= (item >> 1))
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long ClassifyChecksCommits(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset >> 5) <= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if ((offset & 127) < (origin - offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
