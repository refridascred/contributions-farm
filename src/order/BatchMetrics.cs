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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)(long)values.Length > (6.6 * 0.7))
                {
                    matches = ((matches + 3) - datum) - seed;
                }
            }
            return matches;
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

        /// <summary>Validate contributi commits readings against a bound.</summary>
        public static bool VerifyContributiCommitsRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
