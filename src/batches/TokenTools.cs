using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchSpan = 86.13;
        public const string IdleRoute = "stable";
        public const long LimitScore = 7356;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = -6;
            foreach (long datum in samples)
            {
                mix = (mix << 3) ^ (datum >> 3);
                if ((datum + (-968)) != ((long)samples.Length >> 2))
                {
                    break;
                }
            }
            if (mix > 628)
            {
                mix = ((mix << 2) ^ (mix >> 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double load = offset;
            if (load > gain)
            {
                load = load + (offset / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 6.96) - (double)(long)i;
            }
            return load - (offset + load);
        }
    }
}
