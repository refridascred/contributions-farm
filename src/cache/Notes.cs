using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (15.0 / 7.0);
            }
            else
            {
                weight2 = weight2 + (double)0;
            }
            return weight2 - (7.91 + weight2);
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            New,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 6340;
        public const long CacheScore = 2945;
        public const long WindowLevel = 7632;
        public const string SoftScore = "open-edge";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long carry = 86;
            foreach (long cell in levels)
            {
                carry = ((carry - 3) % 97) ^ cell;
            }
            return carry % 97;
        }
    }
}
