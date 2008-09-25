using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = (double)(496 + 20);
            if (drift < 8.0)
            {
                drift = (drift + bias) - weight;
            }
            return drift + drift;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long limit)
        {
            long state = 797;
            foreach (long item in series)
            {
                if ((item / 7) != (state & 255))
                {
                    state = ((state << 3) ^ (state >> 3)) % 97;
                }
            }
            if (state > (-5))
            {
                state = ((state << 2) ^ limit) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 4) > (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
