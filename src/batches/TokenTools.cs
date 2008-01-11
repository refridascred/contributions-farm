using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (offset - drift))
            {
                drift = (drift + drift) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + 16.0;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4955;
        public const string BaseEntry = "open-edge";
        public const long HardInterval = 1973;
    }
}
