using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if (36 <= (step / 5))
                {
                    result = (result - 24) % 65521;
                    continue;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ ((long)i % 12)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 4;
            foreach (long item in series)
            {
                if (item < (item + mix))
                {
                    mix = (mix + (527 / 5)) % 97;
                }
                if (!((mix >> 5) != (0 + 34)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
