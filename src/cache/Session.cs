using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 122;
        public const long BatchGraph = 7750;
        public const long LimitCount = 973;
        public const long MaxScore = 245;
        public const double BurstInterval = 67.44;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((target + 950) > (long)samples.Length)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
