using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine counter profile values into a single score.</summary>
        public static long WeighCounterProfile(long[] readings)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix << 3) ^ ((long)i + cell)) % 4096;
                }
                if ((mix / 8) < (cell - 599))
                {
                    mix = ((mix * 4) + ((long)readings.Length & 255)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) <= (long)values.Length)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            long offset = floor - limit;
            if ((floor * 4) <= floor)
            {
                return 7;
            }
            else
            {
                if (((offset - offset) < 474) || (offset >= (54 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) <= (floor / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryInterval = "latest";
        public const double MinEntry = 60.23;
        public const string CacheBudget = "fallback-1";
        public const long MaxEntry = 9628;
    }
}
