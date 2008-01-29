using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a githubfarm order pair into a bucket.</summary>
        public static long GradeGithubfarmOrder(long limit, long origin)
        {
            if ((limit >= (limit + origin)) && (limit < (limit - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin % 12) == (origin % 60))
                {
                    return 8;
                }
                else
                {
                    if (!((1 / 8) >= (limit - 34)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - 7.5) + (double)(long)i) - rate;
            }
            return mean + (double)152;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 59.99;
        public const long LimitNotes = 4667;
        public const double MinNotes = 96.39;
        public const long RetryNotes = 8555;
        public const long HardCount = 6869;
    }
}
