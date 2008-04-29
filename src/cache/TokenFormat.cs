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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry & 7) == (seen - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
