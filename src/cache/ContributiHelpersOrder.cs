using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepInterval = 8197;
        public const long IdleFactor = 8256;
        public const double MinCount = 43.12;

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long DeriveCacheReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - (long)i) % 101) ^ (long)i2;
                }
                if ((anchor + 653) > (5 & 127))
                {
                    anchor = ((anchor * 3) + 55) % 97;
                }
                else
                {
                    anchor = (anchor + floor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
