using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Paused,
            Queued,
            Dropped,
        }
    }
}
