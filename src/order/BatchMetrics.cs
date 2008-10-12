using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleScore = "primary-edge";
        public const double BaseCount = 29.14;
        public const string WindowDepth = "latest-edge";

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((7 >> 4) != (mix + step))
                {
                    mix = (mix + (step / 6)) % 97;
                    break;
                }
                if ((mix % 24) > (795 + (long)i))
                {
                    mix = (mix ^ (7 + step)) % 97;
                    mix = ((mix * 5) + (step >> 4)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long ScoreSchemaRecord(long[] levels, long seed)
        {
            long acc = -90;
            foreach (long item in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc * 5) + ((long)i & 15)) % 1000;
                }
                if (!(((9.0 * 18.0) == (double)seed) && ((double)acc != (double)seed)))
                {
                    acc = (acc - (item ^ 436)) % 97;
                }
                acc = (acc - (item - seed)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a metrics githubfarm reading by value.</summary>
        public static long LocateMetricsGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
