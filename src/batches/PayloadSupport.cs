using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Rank checks metric input into a small class.</summary>
        public static long SortChecksMetric(long floor, long seed)
        {
            if (seed > (floor * 4))
            {
                return 3;
            }
            else
            {
                if (floor < (seed % 5))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) <= (floor ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((78 / 5) == (seed / 5)) && ((double)seed <= (double)floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
