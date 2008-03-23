using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a route stats pair into a bucket.</summary>
        public static long ClassifyRouteStats(long step, long target)
        {
            if ((double)step == (9.13 - 5.0))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (2.56 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= 6.4)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step < (13.0 / 6.0)) || ((step ^ 5) > (step / 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Locked,
            Pending,
            New,
            Dropped,
        }
    }
}
