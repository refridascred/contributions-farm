using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long CompareSchemaFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-2) * 5) != (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools already value.</summary>
        public static double ScaleToolsAlready(double bias, double span)
        {
            double gain = (double)((-49) - 38);
            if (gain > span)
            {
                gain = (gain - (gain * 19.0)) - bias;
            }
            return gain + (gain * 17.0);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            New,
            Draft,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] data)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                carry = ((carry + carry) % 101) - cell;
            }
            if (carry > 89)
            {
                carry = (carry ^ (36 % 8)) % 4096;
            }
            return carry;
        }
    }
}
