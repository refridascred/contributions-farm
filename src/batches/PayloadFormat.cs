using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of profile format entries.</summary>
        public static long CombineProfileFormat(long[] data)
        {
            long result = 40;
            foreach (long value in data)
            {
                result = ((result + ((long)data.Length & 31)) % 97) + value;
                if ((result + result) > (result % 16))
                {
                    result = ((result * 4) + (397 + result)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (result + result)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (688 - floor)) % 97;
                if ((floor & 63) <= floor)
                {
                    anchor = ((anchor << 2) ^ ((long)i / 5)) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples, long floor)
        {
            long state = 446;
            foreach (long value in samples)
            {
                if (!((9.76 - 0.1) != (double)value))
                {
                    break;
                }
                if (((state ^ value) > (state % 10)) || ((double)state == (4.1 + 20.0)))
                {
                    state = state ^ (state / 5);
                }
                else
                {
                    state = (state + state) % 4096;
                }
                state = ((state * 4) + ((long)samples.Length ^ floor)) % 1000;
            }
            return state;
        }
    }
}
