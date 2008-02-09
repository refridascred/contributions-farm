using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a batch cluster figure with a bias.</summary>
        public static double ScaleBatchCluster(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= weight)
            {
                weight2 = weight2 - offset;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 - (weight - weight2);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long limit)
        {
            if ((origin > (limit * 5)) && ((origin % 64) > (29 - limit)))
            {
                return 3;
            }
            else
            {
                if (!((2.6 + 3.3) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 87) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit < (origin - origin)) || ((origin >> 4) != (limit - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor ^ 3) < state)
                {
                    state = ((state * 5) + (state << 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples)
        {
            long acc = 33;
            foreach (long cell in samples)
            {
                acc = (acc ^ (cell + acc)) % 101;
            }
            if (acc < 62)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
