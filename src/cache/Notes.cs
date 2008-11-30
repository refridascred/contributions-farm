using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor2 % 24) >= 522)
            {
                return 6;
            }
            else
            {
                if ((floor2 & 127) < (step + floor2))
                {
                    return 4;
                }
                else
                {
                    if (!(step < 395))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm layout sample.</summary>
        public static long FindGithubfarmLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4208;
        public const long DefaultProfile = 3583;
        public const long RetryProfile = 1726;
        public const long CacheProfile = 8047;
        public const string MinSize = "standard-edge";

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "open-1";
        public const double MinCount = 19.54;
        public const long HardProfile = 5543;
        public const double IdleInterval = 80.73;
        public const long RetryLevel = 3646;
    }
}
