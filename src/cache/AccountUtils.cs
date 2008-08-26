using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Queued,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSpan = 28.1;
        public const long MinSchema = 248;
        public const long IdleInterval = 7952;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long acc = 44;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ ((long)i / 2)) % 97;
                }
                if (step <= cell)
                {
                    acc = (acc + 9) % 65521;
                }
                if ((7.34 + 2.8) == (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
