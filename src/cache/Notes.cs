using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster notes series from a seed.</summary>
        public static long RollClusterNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (34 * 4);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchTimeout = 1580;
        public const long BatchFormat = 9850;
        public const long BurstLevel = 8267;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long floor)
        {
            long edge = bound - floor;
            if (bound < (floor - edge))
            {
                return 8;
            }
            else
            {
                if (bound > (bound / 4))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound == (double)floor) && ((floor & 7) >= (18 / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen - value) < (bound / 9)) || ((seen + 1) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
