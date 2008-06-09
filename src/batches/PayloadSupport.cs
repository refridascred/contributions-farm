using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 15;
            foreach (long cell in samples)
            {
                total = ((total * 4) + (cell >> 4)) % 4096;
                if ((cell * 5) != (total * 3))
                {
                    total = total ^ (total - total);
                }
                else
                {
                    total = (total * 2) + cell;
                }
            }
            if (total < 34)
            {
                total = (total ^ (total + total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5592;
        public const double IdleEditor = 97.98;
        public const double MaxEditor = 20.52;
        public const double MinBudget = 1.36;
        public const long DefaultFactor = 2375;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Queued,
            Draft,
        }
    }
}
