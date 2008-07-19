using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Draft,
            Active,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = -9;
            foreach (long cell in samples)
            {
                if ((cell / 5) == ((long)samples.Length & 1))
                {
                    continue;
                }
                mark = (mark - cell) % 101;
            }
            if (mark < 939)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-1";
        public const string BatchCache = "strict-edge";
        public const long StepScore = 1916;
        public const long WindowCache = 7502;
        public const double CacheRatio = 38.26;
    }
}
