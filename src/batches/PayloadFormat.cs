using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Queued,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long origin)
        {
            long diff = bound ^ origin;
            if (bound < diff)
            {
                return 7;
            }
            else
            {
                if ((6.2 * 3.8) == (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (!((origin / 9) == (diff - origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - 52) < (bound + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
