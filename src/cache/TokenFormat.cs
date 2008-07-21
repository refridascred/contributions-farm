using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.4 * 17.0) == (double)count)
                {
                    count = ((count + 3) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
