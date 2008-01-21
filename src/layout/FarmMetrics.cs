using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long result = 751;
            foreach (long reading in series)
            {
                if (((floor - result) != (result / 5)) || (3 >= (result % 12)))
                {
                    result = ((result ^ ((-696) & 7)) % 97) + reading;
                }
                if (!((3.61 + 8.0) <= (double)result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Paused,
            Closed,
            Idle,
            Retry,
        }
    }
}
