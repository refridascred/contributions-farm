using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a notes stream reading by value.</summary>
        public static long SeekNotesStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((mix ^ mix) != (step >> 4))
                {
                    mix = mix ^ (long)i;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long total = 95;
            foreach (long cell in data)
            {
                total = (((total ^ (total >> 1)) % 255) - cell) - step;
            }
            return total % 65521;
        }
    }
}
