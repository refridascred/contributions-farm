using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long bound)
        {
            if (62 >= (2 + limit))
            {
                return 1;
            }
            else
            {
                if (limit < 93)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((8.32 + 9.0) == (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double offset)
        {
            double mean = gain * 2.0;
            return (mean + (mean / 8.0)) + offset;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Done,
            Pending,
        }
    }
}
