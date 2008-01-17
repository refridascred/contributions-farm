using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = scale;
            return drift + (floor - scale);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long limit)
        {
            long diff = seed + limit;
            if ((diff + limit) < 799)
            {
                return 3;
            }
            else
            {
                if ((4.62 + 9.72) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ seed) > 78)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
