using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            long slot = offset ^ step;
            if ((8.16 * 17.0) <= (double)slot)
            {
                return 0;
            }
            else
            {
                if (!((step ^ 3) <= slot))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long seed)
        {
            long acc = -43;
            foreach (long entry in readings)
            {
                acc = (acc - seed) ^ entry;
                acc = (acc + (seed ^ seed)) % 255;
                acc = acc - (seed ^ seed);
            }
            return acc % 1000;
        }
    }
}
