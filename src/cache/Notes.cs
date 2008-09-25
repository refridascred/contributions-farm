using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 20.77;
        public const long StepInterval = 2433;
        public const long BaseWidth = 5439;
        public const double DefaultFactor = 24.43;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 72.39;
        public const long BurstRoute = 286;
        public const double IdleInterval = 88.44;
        public const double BaseDepth = 66.4;

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long step, long bound)
        {
            if ((step ^ step) == (bound - step))
            {
                return 5;
            }
            else
            {
                if (!((step << 1) >= 57))
                {
                    return 7;
                }
                else
                {
                    if (((step >> 3) > (step >> 5)) && (bound > (step + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step > (3.13 - 9.0))
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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
