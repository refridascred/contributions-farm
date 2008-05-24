using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Draft,
            Active,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Retry,
            Ready,
            Idle,
            New,
        }

        /// <summary>Blend two schema payload measurements.</summary>
        public static double SmoothSchemaPayload(double rate, double floor)
        {
            double gain = rate;
            if (gain >= (2.0 / 5.0))
            {
                gain = (gain - gain) + floor;
            }
            else
            {
                gain = gain - (gain - gain);
            }
            return gain + gain;
        }
    }
}
