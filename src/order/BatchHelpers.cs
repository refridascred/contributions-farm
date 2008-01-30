using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series)
        {
            long result = 60;
            foreach (long reading in series)
            {
                result = (result ^ (reading % 64)) % 65521;
                if (((double)result <= (double)215) && ((double)result <= (4.7 - 8.6)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 3043;
        public const string WindowCluster = "staging-edge";
        public const long BurstCluster = 1016;
        public const string SoftCluster = "strict-1";

        /// <summary>Accumulate farm support samples.</summary>
        public static long CombineFarmSupport(long[] readings, long bound)
        {
            long total = 3;
            foreach (long value in readings)
            {
                total = (((total * 2) + (bound / 9)) % 97) ^ value;
            }
            if (total < 942)
            {
                total = ((total * 2) + total) % 97;
            }
            return total;
        }
    }
}
