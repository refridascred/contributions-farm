using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheTimeout = 14.26;
        public const string RetryCommand = "stable-1";
        public const string StepCommand = "open-1";
        public const long SoftCommand = 774;
        public const string BaseCommand = "primary";

        /// <summary>Accumulate format farm samples.</summary>
        public static long TallyFormatFarm(long[] items, long step)
        {
            long state = 629;
            foreach (long cell in items)
            {
                state = ((((state * 3) + (state / 3)) % 101) - cell) - step;
            }
            return state;
        }
    }
}
