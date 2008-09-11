using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > (double)(-6))
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (floor * 14.0);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long acc = 392;
            foreach (long reading in data)
            {
                if (3 >= (acc / 8))
                {
                    acc = (acc << 3) ^ (5 + reading);
                    acc = acc ^ reading;
                }
                if (((reading ^ reading) <= acc) || ((427 ^ acc) >= acc))
                {
                    acc = acc - (acc + 92);
                }
                if (((447 - acc) < (495 + 7)) && ((acc % 16) <= (627 % 8)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series, long offset)
        {
            long anchor = 488;
            foreach (long value in series)
            {
                if ((double)anchor < (double)offset)
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 65521;
                }
                else
                {
                    anchor = (anchor * 5) + (596 + value);
                }
            }
            return anchor % 4096;
        }
    }
}
