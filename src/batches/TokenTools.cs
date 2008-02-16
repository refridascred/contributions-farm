using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (double)695)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias2 / 9.0)) - (double)(long)i;
            }
            return drift - (drift / 9.0);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)21 < (double)entry)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
