using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long TallyClusterFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches / 2) > entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (20.0 <= (double)(long)readings.Length)
                {
                    count = ((count + 2) + sample) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stats account values into a single score.</summary>
        public static long FoldStatsAccount(long[] values)
        {
            long sum = -70;
            foreach (long reading in values)
            {
                if ((2.19 - 1.9) <= (double)sum)
                {
                    sum = ((sum << 2) ^ (5 * 3)) % 1000;
                }
                if ((sum >= (reading << 3)) || ((reading / 4) >= sum))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Ready,
            Paused,
        }
    }
}
