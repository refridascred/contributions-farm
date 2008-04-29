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

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items)
        {
            long result = 150;
            foreach (long datum in items)
            {
                result = (result + (3 ^ result)) % 101;
                if (datum <= (277 & 1))
                {
                    result = (result - (datum * 2)) % 255;
                }
                else
                {
                    result = (result ^ (datum << 3)) % 101;
                }
            }
            return result % 4096;
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
