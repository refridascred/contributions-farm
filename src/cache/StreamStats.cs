using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) < (value + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long seed)
        {
            if (((seed / 3) < offset) && ((double)offset == (1.11 / 2.0)))
            {
                return 0;
            }
            else
            {
                if (13.0 > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) >= (129 + 151))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.27 - 12.0) < (double)seed) || ((seed >> 2) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema cache entries that pass the check.</summary>
        public static long MeasureSchemaCacheHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((target * 5) != (target / 5))
                {
                    tally = (tally + 3) - value;
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
