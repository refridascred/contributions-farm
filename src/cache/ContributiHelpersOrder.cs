using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long step2 = bound - step;
            if (((6 ^ step) == (bound + bound)) && ((step2 + 1) < (bound / 3)))
            {
                return 6;
            }
            else
            {
                if ((bound & 31) <= (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)step2 <= 2.8)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step) > bound) || ((32 * 5) >= (bound - step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
