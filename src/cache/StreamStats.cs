using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum > (long)data.Length) || ((datum - datum) < ((long)data.Length - datum))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((5.0 + 4.0) >= (double)sample) || ((double)sample > (double)step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 9486;
        public const long MinDepth = 1206;
        public const double MinLevel = 44.34;
        public const long BurstChannel = 7703;
    }
}
