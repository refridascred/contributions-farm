using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long step, long offset)
        {
            long offset2 = step - offset;
            if (!((4.0 + 5.94) > (double)offset))
            {
                return 5;
            }
            else
            {
                if ((step + step) != (offset2 ^ step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values, long limit)
        {
            long acc = 34;
            foreach (long sample in values)
            {
                if ((acc + limit) < (limit ^ sample))
                {
                    acc = (acc ^ (acc % 12)) % 255;
                }
                else
                {
                    acc = (acc - (14 - acc)) % 65521;
                }
            }
            if (acc > 785)
            {
                acc = acc - limit;
            }
            return acc % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchWidth = "local-1";
        public const long MaxQueue = 3707;
        public const long StepDepth = 9881;

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((limit / 5) > 29) && (limit > (seen * 3)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
