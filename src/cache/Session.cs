using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long CountProfileWindowHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((offset / 5) == (matches / 8))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Pending,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                total = ((total - (target + target)) % 65521) ^ reading;
            }
            return total;
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long ScoreMetricsStats(long[] levels, long floor)
        {
            long total = 736;
            foreach (long datum in levels)
            {
                total = (total - (floor + datum)) % 65521;
            }
            return total;
        }
    }
}
