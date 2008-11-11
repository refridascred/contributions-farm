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

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 33.4;
        public const string MaxSpan = "cached-1";
        public const long IdleFactor = 7997;
        public const double BaseCount = 32.29;

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

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Ready,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryTimeout = 6700;
        public const string StepEditor = "legacy";
        public const long BaseEditor = 6576;
    }
}
