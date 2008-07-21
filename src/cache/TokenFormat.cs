using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every schema account entry stays within the limit.</summary>
        public static bool CheckSchemaAccountRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double mean = (double)((-224) << 1);
            if (mean <= floor)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (13.0 + 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (19.0 * 1.5)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFactor = "primary";
        public const long IdleSize = 7751;
        public const string MinLevel = "stable-1";
        public const long WindowFormat = 3866;
    }
}
