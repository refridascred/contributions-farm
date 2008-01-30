using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two batch account measurements.</summary>
        public static double BlendBatchAccount(double bias, double floor)
        {
            double load = 5.7 + (bias / 8.0);
            if (load > (load * 19.0))
            {
                load = (load + 17.0) - floor;
            }
            else
            {
                load = load + (8.43 * 3.27);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias / 4.0)) - (double)(long)i;
            }
            return load - (load * 9.74);
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double ratio = (double)(261 + 48);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - ratio)) + (double)(long)i;
            }
            return ratio + (bias + bias);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
