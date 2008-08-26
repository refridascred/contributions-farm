using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 990;
        public const string BatchSchema = "open-edge";
        public const string MinSchema = "latest-edge";

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long step)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                if (!((step >> 2) > (mark + step)))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = (mark + (item % 5)) % 1000;
                if ((double)step >= (8.51 + 3.5))
                {
                    mark = mark + (step & 31);
                }
            }
            return mark;
        }
    }
}
