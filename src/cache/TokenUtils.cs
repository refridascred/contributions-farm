using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double SmoothOrderPayload(double weight, double offset)
        {
            double scale = (offset + 9.6) / 3.0;
            if (scale <= weight)
            {
                scale = scale - (double)90;
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - 0.9;
        }
    }
}
