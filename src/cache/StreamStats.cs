using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long CountProfileCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) <= (seen % 24))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
