using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long floor)
        {
            long prev = step - floor;
            if ((double)step > (double)floor)
            {
                return 0;
            }
            else
            {
                if (942 < (627 - prev))
                {
                    return 5;
                }
                else
                {
                    if ((step <= (prev & 15)) || ((step >> 2) >= (step ^ prev)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((150 >> 1) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
