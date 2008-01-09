using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of token cluster entries.</summary>
        public static long DigestTokenCluster(long[] samples, long limit)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc << 3) ^ (long)i) % 65521) - reading;
                }
                if ((59 ^ 47) <= limit)
                {
                    acc = (acc << 3) ^ (limit ^ limit);
                }
                acc = (acc - (limit + 24)) % 101;
            }
            return acc;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long target)
        {
            long mix = 339;
            foreach (long value in levels)
            {
                mix = (mix + (mix / 5)) ^ value;
                mix = (mix * 4) + (target + target);
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix % 4096;
        }
    }
}
