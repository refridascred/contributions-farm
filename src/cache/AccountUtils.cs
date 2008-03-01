using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 1834;
        public const long WindowScore = 3275;
        public const long IdleCommits = 9915;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
