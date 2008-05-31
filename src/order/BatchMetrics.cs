using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the report queue series from a seed.</summary>
        public static long RollReportQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)limit < (double)53)
                {
                    sum = ((sum << 3) ^ (sum >> 2)) % 4096;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - (state + state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values, long origin)
        {
            long sum = 16;
            foreach (long entry in values)
            {
                if ((entry < (origin ^ entry)) || (((-8) * 4) >= (origin / 8)))
                {
                    sum = (sum ^ (entry - entry)) % 101;
                }
            }
            if (sum > 7)
            {
                sum = sum + 998;
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftBudget = 26.13;
        public const string BaseTimeout = "cached";
        public const long MaxLevel = 4646;
    }
}
