using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session schema samples.</summary>
        public static long WeighSessionSchema(long[] levels, long seed)
        {
            long acc = 158;
            foreach (long entry in levels)
            {
                acc = ((acc * 2) + (seed >> 1)) ^ entry;
            }
            return acc % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Idle,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                if ((total - total) > 725)
                {
                    total = (total - sample) % 97;
                }
                else
                {
                    total = (total * 3) + total;
                }
            }
            if (total > 27)
            {
                total = (total << 2) ^ (total >> 3);
            }
            return total;
        }
    }
}
