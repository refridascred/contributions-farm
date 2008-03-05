using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Idle,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = score ^ (score * 5);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long acc = 76;
            foreach (long datum in series)
            {
                if ((acc + offset) > (offset / 5))
                {
                    acc = (acc + (datum - 27)) % 4096;
                }
                if (datum < acc)
                {
                    acc = acc ^ datum;
                }
                if ((4.0 / 8.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
