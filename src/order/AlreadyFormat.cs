using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (8.1 * 5.1)) + (double)(long)i) - span;
            }
            return weight + (double)524;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            if ((seed + offset) != (87 - seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) > 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum % 16) == (limit + (long)i))
                {
                    sum = ((sum * 4) + (sum << 3)) % 255;
                    sum = sum + (limit + limit);
                }
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
