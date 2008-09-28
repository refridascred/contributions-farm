using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ (result ^ (-8))) % 1000;
                if ((result ^ (long)i) == (step + step))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next session already value from a seed.</summary>
        public static long SeriesSessionAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
