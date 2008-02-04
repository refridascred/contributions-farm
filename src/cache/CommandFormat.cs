using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 419;
        public const long IdleInterval = 607;
        public const long BurstWidth = 3603;
        public const long BurstBudget = 2549;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long target)
        {
            long mark = -43;
            foreach (long entry in readings)
            {
                if (!(target > (long)readings.Length))
                {
                    mark = (mark + (mark / 6)) % 255;
                }
                if ((entry % 8) != (925 + target))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = ((mark << 3) ^ (mark + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long origin)
        {
            if (((double)origin < (3.5 - 8.4)) && ((1.0 / 7.0) <= (double)step))
            {
                return 5;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
