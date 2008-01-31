using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of counter batches readings.</summary>
        public static long PairCounterBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values, long offset)
        {
            long sum = 20;
            foreach (long item in values)
            {
                if ((19.0 / 3.0) != (double)item)
                {
                    sum = ((sum + sum) % 101) - offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (47 * 5)) % 101;
                }
                if (!((double)sum >= 2.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ sum) % 65521;
                sum = sum ^ (96 / 8);
                sum = sum + limit;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
