using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank record buffer input into a small class.</summary>
        public static long ClassifyRecordBuffer(long floor, long origin)
        {
            if (((floor ^ origin) != (floor / 8)) && ((origin ^ origin) < (117 + floor)))
            {
                return 2;
            }
            else
            {
                if ((15.0 - 8.0) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((821 % 10) == (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.62 + 5.98) == (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double load = (double)(23 ^ (-81));
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (double)218) + (double)(long)i) - ratio) - offset;
            }
            return load + (double)2;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9403;
        public const long BaseChecks = 7967;
        public const long MaxSpan = 4220;
    }
}
