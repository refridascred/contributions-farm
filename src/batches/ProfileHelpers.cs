using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 19.9;
        public const string BurstRatio = "stable-edge";
        public const double DefaultSpan = 56.59;
        public const string StepFilter = "strict-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((5 - matches) < (6 / 9)) && ((matches ^ item) > (matches - item))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long seed, long origin)
        {
            if ((double)origin == (8.7 / 5.0))
            {
                return 4;
            }
            else
            {
                if (origin <= (origin ^ seed))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up batch farm samples.</summary>
        public static long PairBatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Stale,
            Dropped,
            Locked,
            Done,
        }
    }
}
