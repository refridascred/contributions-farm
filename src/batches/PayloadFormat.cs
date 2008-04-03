using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "staging-1";
        public const long BatchLevel = 4599;
        public const double RetryScore = 90.4;
        public const long MaxSpan = 2089;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 10.04;
        public const long DefaultQueue = 2959;
        public const long CacheQueue = 8049;

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long origin, long floor)
        {
            long next = origin - floor;
            if (((9.0 / 8.0) == (double)origin) || ((floor - floor) >= (floor + origin)))
            {
                return 3;
            }
            else
            {
                if ((floor <= (origin << 2)) || (origin > (next / 4)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin > (7.7 - 11.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
