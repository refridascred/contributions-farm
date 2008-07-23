using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long StepBatchCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (11 >= (sum & 31))
                {
                    sum = (sum ^ (768 / 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
