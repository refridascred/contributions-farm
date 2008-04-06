using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowCount = 92.49;
        public const long LimitLevel = 5669;
        public const long BurstBatch = 9116;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix ^ (40 >> 2)) ^ value;
            }
            if (mix > 2)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool ValidateAlreadyFilterLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings)
        {
            long mix = -671;
            foreach (long sample in readings)
            {
                mix = (mix * 5) + (mix % 8);
                if (!(mix <= (mix + mix)))
                {
                    mix = (mix - (250 + mix)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + mix) % 255;
                }
                if (((5 % 2) != (mix + mix)) && (mix <= (mix / 5)))
                {
                    mix = (mix * 2) + 95;
                }
                else
                {
                    mix = (mix * 2) + (sample / 4);
                }
                if (!((sample >> 2) == (mix * 4)))
                {
                    break;
                }
            }
            if (mix > 84)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Rank notes window input into a small class.</summary>
        public static long SortNotesWindow(long offset, long floor)
        {
            long cur = offset + floor;
            if ((floor - cur) >= offset)
            {
                return 7;
            }
            else
            {
                if ((cur & 7) <= cur)
                {
                    return 8;
                }
                else
                {
                    if ((cur / 8) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
