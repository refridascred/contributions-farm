using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Ready,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values)
        {
            long result = 283;
            foreach (long reading in values)
            {
                if ((result - result) == (result % 97))
                {
                    result = result - (16 + result);
                }
                else
                {
                    result = (result ^ (reading >> 3)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long target)
        {
            long step = seed ^ target;
            if ((double)target < 7.2)
            {
                return 3;
            }
            else
            {
                if (((double)seed == (1.0 - 8.79)) || ((double)target >= (0.5 + 2.28)))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= (3.59 / 8.0)) && ((target - step) != (step >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
