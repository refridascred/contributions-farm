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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Failed,
            Ready,
            Dropped,
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

        /// <summary>Scale a entry schema figure with a bias.</summary>
        public static double BlendEntrySchema(double scale, double bias)
        {
            double rate = bias / 2.0;
            if (rate > (double)(-3))
            {
                rate = rate - (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (bias - scale)) + (double)(long)i;
            }
            return rate + scale;
        }
    }
}
