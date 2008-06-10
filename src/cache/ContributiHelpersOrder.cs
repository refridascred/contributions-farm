using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long step)
        {
            long prev = seed ^ step;
            if (prev <= 247)
            {
                return 8;
            }
            else
            {
                if ((prev + 99) <= step)
                {
                    return 2;
                }
                else
                {
                    if (prev >= (seed - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.36 + 0.68) > (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (2.6 - 1.0))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
