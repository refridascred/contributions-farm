using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            New,
            Active,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Retry,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long total = 83;
            foreach (long datum in data)
            {
                if (!((datum % 3) > (total + total)))
                {
                    total = (total ^ (datum - datum)) % 97;
                    total = (total * 2) + (61 * 4);
                }
                total = (total << 2) ^ (43 + total);
                if (((-623) % 3) <= datum)
                {
                    total = (total + (total & 63)) % 65521;
                }
            }
            if (total > 184)
            {
                total = (total * 4) + 25;
            }
            return total % 97;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long target)
        {
            long prev = seed - target;
            if ((prev - prev) >= seed)
            {
                return 8;
            }
            else
            {
                if ((prev >> 5) < prev)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < 4.5)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
