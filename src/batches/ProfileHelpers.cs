using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((step & 63) > (reading >> 1)) && (((step * 5) >= ((long)values.Length + 0)) && (reading >= (reading + 9))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 377;
        public const string MaxCount = "stable-v2";
        public const long BatchSize = 1239;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double BlendContextStream(double scale, double floor)
        {
            double scale2 = (double)(9 % 97);
            if (scale2 > floor)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (scale / 4.0);
        }

        /// <summary>Derive the next metrics commits value from a seed.</summary>
        public static long IterateMetricsCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((sum >> 1) >= sum)
                {
                    continue;
                }
                sum = (sum ^ (sum << 2)) % 255;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
