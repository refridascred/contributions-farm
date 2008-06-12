using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Closed,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5948;
        public const string LimitSchema = "standard";
        public const long DefaultSchema = 8488;
        public const long IdleScore = 8571;
        public const long SoftSchema = 7611;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            New,
            Pending,
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

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data, long limit)
        {
            long result = 52;
            foreach (long sample in data)
            {
                result = ((((result << 2) ^ (7 / 9)) % 65521) ^ sample) + limit;
            }
            return result;
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
