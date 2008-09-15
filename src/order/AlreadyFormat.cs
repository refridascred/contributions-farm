using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 2070;
        public const long BaseEntry = 3345;
        public const long CacheCount = 7914;
        public const long StepEntry = 2256;

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long bound)
        {
            long span = floor + bound;
            if (bound <= (829 << 1))
            {
                return 8;
            }
            else
            {
                if ((double)262 < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((span + floor) != (span ^ span))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor % 100) <= (83 - span)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7061;
        public const double CacheInterval = 17.63;
        public const long MinRoute = 7433;
        public const double IdleRoute = 92.47;
        public const long CacheRoute = 2151;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
