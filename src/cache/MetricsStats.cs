using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long SeekCounterPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((origin > (origin - origin2)) && ((5.0 / 3.0) >= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((8.1 / 9.0) >= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((origin2 > (origin2 - edge)) && ((origin2 & 7) != (edge + origin2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Retry,
            Done,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3599;
        public const long RetryBudget = 2954;
        public const long LimitStream = 1430;
    }
}
