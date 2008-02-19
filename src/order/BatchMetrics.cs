using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long CountEditorFarmGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) < (value / 8))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 712;
            foreach (long reading in samples)
            {
                carry = ((carry + reading) % 97) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Rank graph farm input into a small class.</summary>
        public static long BucketGraphFarm(long floor, long offset)
        {
            long prev = floor - offset;
            if ((double)prev != (double)0)
            {
                return 5;
            }
            else
            {
                if ((83 - floor) > offset)
                {
                    return 4;
                }
                else
                {
                    if ((6.5 + 3.28) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Paused,
            Done,
            Locked,
        }
    }
}
