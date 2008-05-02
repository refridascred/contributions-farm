using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if (!(floor2 > (floor2 ^ diff)))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (7.4 - 4.4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - seen) != (seen - 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long offset)
        {
            long state = 78;
            foreach (long value in samples)
            {
                if ((offset / 8) != (value + 1))
                {
                    state = state - state;
                }
            }
            if (state > 69)
            {
                state = (state << 3) ^ (offset + state);
            }
            return state;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
