using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Stale,
            Locked,
        }

        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool VerifyTokenQueueLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stream metrics readings against a bound.</summary>
        public static bool ValidateStreamMetricsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long step)
        {
            long sum = 418;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (step + value);
                if (!!((double)step != (6.2 - 5.8)))
                {
                    sum = (sum << 2) ^ (step / 2);
                }
                if (459 > value)
                {
                    sum = ((sum << 3) ^ (step - 7)) % 255;
                }
                else
                {
                    sum = (sum ^ (step / 2)) % 101;
                }
                if ((sum % 12) < (value << 3))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
