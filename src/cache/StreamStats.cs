using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches cache entries.</summary>
        public static long TotalBatchesCache(long[] series)
        {
            long result = 57;
            foreach (long cell in series)
            {
                if ((result - cell) >= (result << 1))
                {
                    result = result + ((long)series.Length + 54);
                }
                result = (result + (result + cell)) % 97;
            }
            if (result < 4)
            {
                result = (result * 5) + (result >> 4);
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)origin > 16.0)
                {
                    sum = (sum + (7 / 7)) % 1000;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = sum - (sum - origin);
                sum = sum - ((long)i % 7);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
