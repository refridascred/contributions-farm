using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long step)
        {
            if ((step ^ step) < ((-3) - origin))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) == (origin & 127))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 415;
            foreach (long item in readings)
            {
                mix = ((mix << 2) ^ mix) - item;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (weight + weight) / 9.0;
            if (load >= floor)
            {
                load = load + 19.0;
            }
            else
            {
                load = load + 4.1;
            }
            return load + (weight + load);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
