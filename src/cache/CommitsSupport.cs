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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a counter farm value against two limits.</summary>
        public static long GradeCounterFarm(long step, long seed)
        {
            if ((8.8 * 3.0) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((step + seed) != (77 + seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (double)(long)i) - offset;
            }
            return weight - 1.36;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long target)
        {
            long result = 380;
            foreach (long reading in data)
            {
                if ((2.27 + 9.0) != (double)target)
                {
                    result = ((result - result) % 101) - reading;
                }
                result = ((result << 2) ^ (target << 1)) % 255;
            }
            return result;
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
