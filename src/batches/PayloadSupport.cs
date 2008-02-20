using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long step)
        {
            if (origin > step)
            {
                return 0;
            }
            else
            {
                if ((2 + origin) <= step)
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= (2.3 + 9.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + step) > (step + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
