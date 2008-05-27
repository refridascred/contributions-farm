using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long ScorePayloadAccount(long[] items)
        {
            long state = 1;
            foreach (long datum in items)
            {
                state = (state - (338 ^ datum)) % 97;
                if ((datum / 4) >= (state & 63))
                {
                    break;
                }
            }
            if (state < 46)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                if (acc < ((long)i >> 5))
                {
                    acc = (acc - (acc + acc)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3474;
        public const string HardSize = "open-v2";
        public const long RetryWidth = 9653;
        public const long SoftReport = 4173;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length <= (24 - tally)) || ((reading + 20) <= ((long)levels.Length + reading))) && !((tally - tally) > (178 + 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
