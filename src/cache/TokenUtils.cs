using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 4;
            foreach (long datum in series)
            {
                acc = (acc ^ (905 % 5)) % 65521;
                if ((acc - acc) == (datum + datum))
                {
                    acc = ((acc * 2) + (datum ^ datum)) % 255;
                }
            }
            return acc % 1000;
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
