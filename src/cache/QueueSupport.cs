using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate channel contributi samples.</summary>
        public static long WeighChannelContributi(long[] series, long bound)
        {
            long carry = -49;
            foreach (long value in series)
            {
                carry = ((carry ^ (11 - value)) % 4096) + bound;
                if ((0 << 2) > value)
                {
                    carry = (carry + (value / 7)) % 255;
                }
                carry = carry + (long)series.Length;
            }
            return carry % 97;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= ((-42) << 2))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
