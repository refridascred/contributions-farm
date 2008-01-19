using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings, long origin)
        {
            long carry = 98;
            foreach (long entry in readings)
            {
                if ((origin + 80) != (99 - (-7)))
                {
                    carry = (carry - (82 * 5)) + entry;
                }
            }
            if (carry > 98)
            {
                carry = carry - (carry - origin);
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long score = -13;
            foreach (long reading in values)
            {
                score = ((score + (score & 31)) % 4096) - reading;
            }
            if (score > 165)
            {
                score = (score ^ (score ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleInterval = 83.76;
        public const long SoftLevel = 7044;
        public const long StepCommand = 7405;
        public const long MaxFactor = 6877;
        public const long IdleDepth = 4873;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
