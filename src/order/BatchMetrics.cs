using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const long IdleInterval = 4224;
        public const string DefaultSize = "stable";
        public const string SoftCount = "alpha-1";
        public const string StepBuffer = "staging";

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TotalClusterSession(long[] samples)
        {
            long state = 8;
            foreach (long value in samples)
            {
                if ((value & 1) <= (value - state))
                {
                    state = (state ^ state) % 65521;
                }
            }
            if (state > 7)
            {
                state = state + (state & 31);
            }
            return state;
        }

        /// <summary>Project the next graph support value.</summary>
        public static double AdjustGraphSupport(double rate, double offset)
        {
            double mean = (double)140 - (double)275;
            return ((mean - 3.21) + rate) + offset;
        }
    }
}
