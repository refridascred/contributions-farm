using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the profile account series from a seed.</summary>
        public static long SeriesProfileAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if (!(state >= (state % 3)))
                {
                    long tally = (state - target) / 6;
                    state = (state - (203 + tally)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                long edge = offset;
                if (((edge << 3) < anchor) || ((10.0 - 13.0) != (double)edge))
                {
                    edge = edge - ((long)i ^ edge);
                }
                edge = (edge - (anchor - (long)i)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data)
        {
            long result = 875;
            foreach (long sample in data)
            {
                result = (result * 2) + result;
                result = (result ^ sample) % 65521;
                if ((((long)data.Length & 127) != (result << 1)) || ((sample + result) > sample))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result % 97;
        }
    }
}
