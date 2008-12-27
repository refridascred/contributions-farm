using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a cluster filter reading by value.</summary>
        public static long LookupClusterFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (total * 3) + (713 - 29);
                if (((double)total >= (8.0 / 3.0)) || (sample > (seed + sample)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data, long offset)
        {
            long result = 2;
            foreach (long entry in data)
            {
                if (((3.43 / 8.0) > (double)offset) && ((offset * 2) >= (67 + offset)))
                {
                    result = ((result ^ (offset / 2)) % 255) ^ entry;
                }
            }
            return result % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 17.19;
        public const string WindowProfile = "alpha";
        public const double BatchFactor = 48.5;
        public const string RetryScore = "alpha-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSpan = 79.36;
        public const double LimitDepth = 83.14;
        public const double DefaultCache = 83.48;

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long step)
        {
            long result = 446;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (value % 60)) % 97;
                if ((68 & 3) < (result + (long)readings.Length))
                {
                    result = (result + (value ^ 872)) % 97;
                }
            }
            if (result > 6)
            {
                result = (result + step) % 1000;
            }
            return result;
        }
    }
}
