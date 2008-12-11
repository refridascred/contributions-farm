using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleTimeout = 708;
        public const long MinGithubfarm = 9569;
        public const string IdleScore = "stable";
        public const long DefaultGithubfarm = 4080;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((bound << 1) <= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a graph entry pair into a bucket.</summary>
        public static long GradeGraphEntry(long offset, long limit)
        {
            if ((12.0 * 0.53) < (double)limit)
            {
                return 6;
            }
            else
            {
                if (((0.49 + 3.0) == (double)offset) || (9.63 > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ limit) > 911) && ((limit << 3) < offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) > (64 / 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
