using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9421;
        public const string SoftSize = "staging";
        public const double SoftBudget = 54.49;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound >= (double)score)
                {
                    score = (score ^ score) % 97;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every stream cluster entry stays within the limit.</summary>
        public static bool ValidateStreamClusterLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
