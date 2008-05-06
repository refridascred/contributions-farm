using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((long)readings.Length >= (sample & 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = (total - step) % 97;
                if (step <= (22 + (long)i))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
