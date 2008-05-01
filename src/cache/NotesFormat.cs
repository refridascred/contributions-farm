using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = (weight - weight) + ratio;
            }
            return weight + (double)89;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Closed,
            Failed,
        }
    }
}
