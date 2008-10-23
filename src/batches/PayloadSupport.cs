using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 20.0) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Retry,
            Draft,
            Active,
            Stale,
        }
    }
}
