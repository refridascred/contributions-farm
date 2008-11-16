using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 91.26;
        public const long BaseSize = 2602;
        public const long MaxLayout = 1820;
        public const double SoftLayout = 19.4;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
