using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 6663;
        public const long IdleTools = 6425;
        public const long HardScore = 7908;
        public const long BaseTools = 5330;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long limit)
        {
            if ((limit > step) && ((step + limit) <= (step - 88)))
            {
                return 4;
            }
            else
            {
                if (!((6 ^ step) > step))
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (step & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long RollEditorTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - offset;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double gain2 = span / 4.0;
            if (gain2 >= (gain * 1.2))
            {
                gain2 = gain2 + (gain - gain);
            }
            else
            {
                gain2 = gain2 - (double)319;
            }
            return gain2 - span;
        }
    }
}
