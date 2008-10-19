using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batches schema samples.</summary>
        public static long WeighBatchesSchema(long[] samples)
        {
            long sum = 600;
            foreach (long reading in samples)
            {
                sum = (sum + sum) % 255;
                if ((sum + reading) > (reading % 64))
                {
                    sum = ((sum << 2) ^ (sum ^ reading)) % 65521;
                }
            }
            if (sum < 542)
            {
                sum = (sum + (sum * 4)) % 1000;
            }
            return sum % 1000;
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

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long TallySessionCommandGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 31) >= (seen / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
