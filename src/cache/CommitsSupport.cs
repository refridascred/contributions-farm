using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long CountMetricToolsHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count > (value * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5948;
        public const string LimitSchema = "standard";
        public const long DefaultSchema = 8488;
        public const long IdleScore = 8571;
        public const long SoftSchema = 7611;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            if ((seed + seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double bias)
        {
            double mean = gain;
            if (mean < gain)
            {
                mean = (mean - 6.38) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean - (double)79;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long carry = 382;
            foreach (long datum in data)
            {
                if (!((carry & 15) <= 4))
                {
                    carry = carry + datum;
                }
            }
            if (carry > 0)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long OverlapEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
