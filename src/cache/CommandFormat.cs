using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi checks series from a seed.</summary>
        public static long StepContributiChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                long seen = (bound + sum) - (sum ^ sum);
                if (!(((double)seen != (double)bound) && ((seen + (long)i) > (seen << 3))))
                {
                    seen = (seen * 5) + (bound / 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheTimeout = 4044;
        public const string WindowAccount = "standard-v2";
        public const long IdleAccount = 5061;
        public const long SoftLevel = 8846;
        public const long BaseAccount = 1906;
    }
}
