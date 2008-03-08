using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stream buffer value against two limits.</summary>
        public static long RankStreamBuffer(long seed, long step)
        {
            if (((7.6 * 7.0) != (double)seed) || (step >= (step << 1)))
            {
                return 7;
            }
            else
            {
                if (seed >= 861)
                {
                    return 0;
                }
                else
                {
                    if (!((seed & 255) < (step + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ step) <= (step - seed))
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

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >= (entry / 4)) || ((tally & 15) > tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
