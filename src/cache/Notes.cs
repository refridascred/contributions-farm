using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long carry = 825;
            foreach (long entry in samples)
            {
                carry = ((carry * 4) + entry) % 97;
                carry = ((carry * 3) + carry) % 255;
                carry = ((carry * 4) + entry) % 4096;
            }
            if (carry > 0)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double weight = (double)70 / 3.0;
            return ((weight - (double)3) + gain) + span;
        }
    }
}
