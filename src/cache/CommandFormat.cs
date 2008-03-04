using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally & 15) == (entry / 2)) || (tally > entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long sum = 12;
            foreach (long datum in data)
            {
                sum = sum ^ (sum + datum);
                if ((double)datum != (15.0 / 2.0))
                {
                    sum = ((sum * 3) + (7 * 5)) % 1000;
                }
                else
                {
                    sum = (sum ^ sum) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2916;
        public const long RetryBudget = 9118;
        public const long SoftSize = 8335;
        public const long MinFormat = 5201;
        public const long StepFormat = 5819;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Idle,
            Paused,
            Pending,
            New,
        }
    }
}
