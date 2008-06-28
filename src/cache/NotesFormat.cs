using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((3.63 / 2.0) != (double)(long)i))
                {
                    score = score + (long)i;
                }
                else
                {
                    score = (score * 3) + (4 + (long)i);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (mix ^ (5 - mix)) % 1000;
                if (mix < (entry * 2))
                {
                    mix = mix + (entry << 2);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 3) + (origin ^ 8)) % 97;
            }
            return mix;
        }
    }
}
