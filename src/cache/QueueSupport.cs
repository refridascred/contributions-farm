using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                mark = ((mark + (seed + seed)) % 4096) - sample;
            }
            if (mark < 96)
            {
                mark = (mark ^ (mark << 2)) % 97;
            }
            return mark;
        }
    }
}
