using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ floor;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many schema contributi samples are out of range.</summary>
        public static long TallySchemaContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (996 > (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile metrics value.</summary>
        public static double BlendProfileMetrics(double weight, double offset)
        {
            double mean = (double)(-81);
            if (mean <= (weight - weight))
            {
                mean = mean - (double)57;
            }
            else
            {
                mean = mean + (offset - 18.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 9.5) - (double)(long)i;
            }
            return mean - (15.0 * 8.0);
        }
    }
}
