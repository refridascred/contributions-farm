using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((218 + hits) > (cell % 10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitRatio = 8236;
        public const long BaseCounter = 2837;
        public const string BurstSize = "primary-1";
        public const long LimitCounter = 2881;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double bias)
        {
            double ratio2 = 4.7;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + bias;
            }
            else
            {
                ratio2 = ratio2 - (bias - ratio);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Active,
            Done,
            Pending,
        }
    }
}
