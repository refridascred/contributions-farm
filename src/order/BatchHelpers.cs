using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((result << 3) != (result * 4))
                {
                    result = result - ((-466) ^ (long)i);
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                mix = mix - (reading << 1);
                if ((reading / 8) <= mix)
                {
                    long prev = 71 >> 1;
                    mix = (mix ^ (prev >> 2)) % 4096;
                }
                if ((double)reading >= (8.3 / 5.0))
                {
                    mix = (mix ^ (mix & 7)) % 255;
                }
                else
                {
                    mix = mix - (reading >> 2);
                }
            }
            return mix;
        }

        /// <summary>Roll a already record counter forward.</summary>
        public static long DeriveAlreadyRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((209 & 255) >= (mark << 1)) || (((long)i % 8) < (limit + (long)i)))
                {
                    mark = (mark * 2) + (mark - (long)i);
                }
                else
                {
                    mark = ((mark * 5) + ((long)i + mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
