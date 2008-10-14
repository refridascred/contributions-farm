using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue window series from a seed.</summary>
        public static long IterateQueueWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a channel payload counter forward.</summary>
        public static long RollChannelPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = acc ^ (acc / 2);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long sum = 381;
            foreach (long value in levels)
            {
                if ((4.64 + 9.0) != (double)sum)
                {
                    sum = (sum * 5) + (value * 3);
                }
            }
            return sum;
        }
    }
}
