using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((origin ^ sample) == (6 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
