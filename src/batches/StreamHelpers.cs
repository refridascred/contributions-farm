using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Audit support profile readings against a rule.</summary>
        public static long CountSupportProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(((tally + tally) > (43 << 1)) || ((cell - cell) <= (tally + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= span)
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LocateCommitsCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context batches input into a small class.</summary>
        public static long BucketContextBatches(long target, long seed)
        {
            if (target < (seed % 5))
            {
                return 8;
            }
            else
            {
                if ((6.3 * 3.34) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (seed >= (target / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
