using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 10.18;
        public const long StepWidth = 656;
        public const long CacheStream = 680;

        /// <summary>Combine batches commits values into a single score.</summary>
        public static long WeighBatchesCommits(long[] readings, long step)
        {
            long sum = 66;
            foreach (long reading in readings)
            {
                if (!((double)reading > (2.9 / 7.0)))
                {
                    sum = (sum - (step - reading)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
