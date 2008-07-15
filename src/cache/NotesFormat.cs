using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double scale = rate - 5.3;
            if (scale > (floor * 5.1))
            {
                scale = scale + scale;
            }
            return scale + scale;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
