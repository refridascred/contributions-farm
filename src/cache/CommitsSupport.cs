using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4737;
        public const long RetryScore = 6420;
        public const double CacheFactor = 71.69;
        public const long BaseProfile = 3575;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Draft,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if (mix < 990)
                {
                    mix = ((mix ^ (mix + 656)) % 97) ^ datum;
                }
            }
            return mix % 65521;
        }
    }
}
