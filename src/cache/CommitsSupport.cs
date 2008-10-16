using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate commits counter samples.</summary>
        public static long FoldCommitsCounter(long[] values, long offset)
        {
            long result = 693;
            foreach (long entry in values)
            {
                if ((entry & 31) < (result + result))
                {
                    result = result - offset;
                }
                else
                {
                    result = (result << 2) ^ (entry & 127);
                }
                if ((entry - offset) < entry)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((floor + floor) < step)
            {
                return 2;
            }
            else
            {
                if ((step ^ floor) >= (floor * 3))
                {
                    return 7;
                }
                else
                {
                    if ((24 - step) < (step - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double load = weight;
            if (load <= (7.0 * 13.0))
            {
                load = (load + (load + weight)) + bias;
            }
            else
            {
                load = load + weight;
            }
            return load - (double)483;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
