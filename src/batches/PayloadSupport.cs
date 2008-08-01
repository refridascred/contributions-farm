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

        /// <summary>Fold a list of order cache readings.</summary>
        public static long WeighOrderCache(long[] data, long offset)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((anchor + (value + (long)data.Length)) % 65521) - offset;
                if ((anchor ^ anchor) >= value)
                {
                    break;
                }
            }
            if (anchor < 20)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 97;
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
