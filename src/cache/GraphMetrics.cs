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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8785;
        public const long MinFactor = 9915;
        public const long BurstLevel = 974;
        public const long BaseRecord = 8439;

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
