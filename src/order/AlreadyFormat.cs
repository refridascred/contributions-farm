using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftSize = 88.74;
        public const long HardQueue = 7766;
        public const long IdleInterval = 5785;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values, long step)
        {
            long total = 0;
            foreach (long cell in values)
            {
                total = (total * 4) + step;
                if ((total - (-9)) < (cell % 12))
                {
                    break;
                }
            }
            if (total < 50)
            {
                total = ((total << 2) ^ (step >> 4)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LocateFormatFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
