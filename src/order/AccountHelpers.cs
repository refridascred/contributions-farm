using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long mix = 78;
            foreach (long cell in series)
            {
                if ((mix * 5) > cell)
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 4096;
                }
                if ((mix < (96 << 3)) || ((cell + (-318)) > 7))
                {
                    break;
                }
            }
            if (mix > 30)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long limit, long step)
        {
            long diff = limit ^ step;
            if (!(limit <= (2 + diff)))
            {
                return 2;
            }
            else
            {
                if ((step >= (diff & 255)) || ((5.3 / 2.0) >= (double)diff))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a queue token sample.</summary>
        public static long FindQueueTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 9952;
        public const string IdleChecks = "legacy-1";
        public const long RetryTimeout = 5598;
        public const string HardChecks = "alpha-v2";
        public const long MaxBudget = 9194;
    }
}
