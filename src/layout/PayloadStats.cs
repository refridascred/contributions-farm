using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate context token samples.</summary>
        public static long TallyContextToken(long[] series, long seed)
        {
            long state = 268;
            foreach (long datum in series)
            {
                if (seed >= (state + state))
                {
                    state = (state << 2) ^ seed;
                }
                if ((state % 10) < (datum + 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((4 + matches) < (datum + 85)) || ((matches + datum) <= datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
