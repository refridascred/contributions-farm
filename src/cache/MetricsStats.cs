using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long sum = 66;
            foreach (long sample in values)
            {
                sum = (sum * 2) + (origin + sample);
            }
            if (sum < (-380))
            {
                sum = (sum << 3) ^ ((long)values.Length * 3);
            }
            return sum;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 80.26;
        public const long LimitLevel = 1185;
        public const string SoftTools = "stable-edge";
        public const long MinTimeout = 6900;
        public const string SoftWidth = "legacy";

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long RollCounterCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (target / 3);
                result = (result << 3) ^ (result << 2);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
