using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every stream batch entry stays within the limit.</summary>
        public static bool VerifyStreamBatchLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long sum = 66;
            foreach (long reading in data)
            {
                if (reading > (sum >> 3))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
