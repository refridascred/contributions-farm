using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - bias2;
            }
            return weight + (bias / 4.0);
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                if (!((acc + 0) <= (261 / 8)))
                {
                    acc = ((acc + (acc ^ acc)) % 1000) ^ cell;
                }
                acc = (acc ^ (37 + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate payload notes readings against a bound.</summary>
        public static bool ValidatePayloadNotesRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
