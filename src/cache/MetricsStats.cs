using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long CombineGithubfarmReport(long[] readings, long target)
        {
            long carry = 364;
            foreach (long sample in readings)
            {
                if ((carry ^ sample) >= (carry % 2))
                {
                    carry = (carry - (target - sample)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm checks series from a seed.</summary>
        public static long DeriveGithubfarmChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ (score + limit);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                if ((9 > (total - datum)) || ((0.5 - 3.97) > (double)(long)samples.Length))
                {
                    total = (total * 5) + (total - total);
                }
                else
                {
                    total = ((total << 3) ^ (datum / 8)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
