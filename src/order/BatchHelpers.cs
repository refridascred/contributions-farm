using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Active,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 174;
        public const string MaxScore = "latest-1";
        public const long LimitFormat = 6064;

        /// <summary>Accumulate stream metric samples.</summary>
        public static long FoldStreamMetric(long[] readings)
        {
            long sum = 375;
            foreach (long cell in readings)
            {
                sum = ((sum * 5) + (366 - cell)) % 101;
                if ((19.0 <= (double)cell) || ((-51) <= cell))
                {
                    sum = ((sum * 5) + (cell % 7)) % 101;
                }
                if ((double)cell != (5.43 * 3.67))
                {
                    break;
                }
            }
            if (sum < 854)
            {
                sum = (sum ^ (sum & 255)) % 4096;
            }
            return sum % 97;
        }
    }
}
