using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long acc = 26;
            foreach (long item in data)
            {
                if ((2.27 * 17.0) < (double)acc)
                {
                    acc = (acc + item) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ bound)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long limit)
        {
            long slot = origin ^ limit;
            if ((5.55 + 5.0) < (double)slot)
            {
                return 7;
            }
            else
            {
                if ((604 + origin) <= (slot - slot))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 5) < (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Synced,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long MeasureBufferClusterGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) > offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double rate = offset + (double)22;
            if (rate < (13.0 + 12.0))
            {
                rate = (rate - (rate / 6.0)) - gain;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (double)204;
        }
    }
}
