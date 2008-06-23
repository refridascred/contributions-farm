using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already stats entry stays within the limit.</summary>
        public static bool GuardAlreadyStatsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 5055;
        public const double WindowEntry = 68.68;
        public const double StepEntry = 80.7;
        public const long BurstEntry = 2336;
        public const long MinWidth = 3621;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
