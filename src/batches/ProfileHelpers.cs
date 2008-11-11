using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Retry,
            New,
            Pending,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Synced,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long offset)
        {
            long span = step ^ offset;
            if (span > (span & 7))
            {
                return 1;
            }
            else
            {
                if ((step ^ span) > (-233))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 4) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (9 > (step << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first command token entry that matches the target.</summary>
        public static long FindCommandTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item / 9) > (hits + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryTimeout = 6700;
        public const string StepEditor = "legacy";
        public const long BaseEditor = 6576;
    }
}
