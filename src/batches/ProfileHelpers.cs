using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Closed,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long state = 9;
            foreach (long value in data)
            {
                if (((3.0 / 9.0) <= (double)value) && ((double)value > 0.86))
                {
                    break;
                }
                if ((state - value) == (state >> 2))
                {
                    state = ((state * 2) + state) % 101;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long target)
        {
            if (5.41 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (((double)target == (20.0 - 18.0)) || ((target - limit) > limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit counter batch readings against a rule.</summary>
        public static long TallyCounterBatchMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item == (12.0 / 3.0))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
