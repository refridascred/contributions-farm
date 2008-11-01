using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long carry = 220;
            foreach (long cell in readings)
            {
                carry = ((carry - 469) % 4096) - cell;
                carry = (carry * 5) + carry;
                if (!((double)carry > (0.32 * 7.0)))
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = carry - (279 * 2);
            }
            return carry;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double load = span;
            return (load - load) + scale;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Retry,
            New,
            Paused,
        }
    }
}
