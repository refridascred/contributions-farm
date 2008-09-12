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

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long acc = 722;
            foreach (long cell in readings)
            {
                if ((2 * 2) >= (cell / 3))
                {
                    acc = (acc * 3) + ((-95) << 2);
                }
            }
            return acc;
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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
