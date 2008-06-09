using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((1.23 / 3.0) != (double)floor)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc ^ (target - 99)) % 101) ^ (long)i2) ^ sample;
                }
                if (target >= acc)
                {
                    acc = (acc ^ (153 << 1)) % 1000;
                }
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ (acc - 9);
            }
            return acc % 97;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Done,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long limit)
        {
            long step = floor + limit;
            if (!((step / 4) > (limit >> 5)))
            {
                return 0;
            }
            else
            {
                if (step <= (limit / 6))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ limit) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
