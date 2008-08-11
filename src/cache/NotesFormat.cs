using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account tools figure with a bias.</summary>
        public static double BlendAccountTools(double ratio, double offset)
        {
            double gain = ratio - (ratio + offset);
            if (gain <= (gain - offset))
            {
                gain = gain + (offset * 19.0);
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            return gain + (gain - ratio);
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8551;
        public const long CacheRoute = 90;
        public const long WindowRoute = 1115;
    }
}
