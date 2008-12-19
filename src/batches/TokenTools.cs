using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate token entry samples.</summary>
        public static long DigestTokenEntry(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                if ((entry + result) > (result & 1))
                {
                    result = result - (result - 36);
                }
                else
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double gain = scale;
            if (gain <= 3.6)
            {
                gain = gain + 5.67;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - floor) - (double)(long)i;
            }
            return gain + (scale - floor);
        }
    }
}
