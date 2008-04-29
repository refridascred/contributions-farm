using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a commits support sample.</summary>
        public static long SeekCommitsSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long seed)
        {
            long total = -99;
            foreach (long reading in series)
            {
                if (((8.0 * 9.7) != (double)(long)series.Length) || ((total / 5) < seed))
                {
                    total = (total ^ (total - reading)) % 97;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mix = 20;
            foreach (long sample in samples)
            {
                mix = mix + ((-41) / 4);
                if ((mix / 6) > sample)
                {
                    break;
                }
            }
            if (mix > 854)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 65521;
        }
    }
}
