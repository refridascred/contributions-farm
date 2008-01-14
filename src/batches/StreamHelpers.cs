using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long CountSchemaSessionOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= (20.0 * 7.0))
                {
                    hits = ((hits + 3) - item) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long TotalClusterCache(long[] series, long step)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                carry = carry ^ (reading ^ step);
            }
            if (carry > (-825))
            {
                carry = (carry + step) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long total = -7;
            foreach (long value in readings)
            {
                total = (total ^ (total - 577)) % 4096;
                total = (total * 5) + (total ^ value);
            }
            return total % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 58.56;
        public const long DefaultQueue = 6335;
        public const long StepInterval = 5823;
        public const double BurstQueue = 44.19;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Ready,
            Dropped,
        }
    }
}
