using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 143;
        public const long WindowContext = 7224;
        public const double HardLevel = 82.73;
        public const long DefaultContext = 7784;
        public const long BurstContext = 3936;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i < anchor) || ((anchor + (long)i) >= (offset % 2)))
                {
                    anchor = (anchor + (long)i) % 65521;
                }
                if (!((offset + 0) < anchor))
                {
                    anchor = (anchor ^ offset) % 65521;
                }
                if ((6.1 - 1.0) != (double)anchor)
                {
                    anchor = (anchor << 2) ^ (anchor - offset);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)0) + (double)(long)i) - ratio;
            }
            return load + (2.34 + 9.89);
        }
    }
}
