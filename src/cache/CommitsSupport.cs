using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Synced,
            New,
            Failed,
            Stale,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((total / 8) >= (long)i) || (total < 0))
                {
                    total = ((total << 2) ^ (total & 127)) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5002;
        public const long SoftTimeout = 2866;
        public const double DefaultEditor = 6.41;
        public const long RetryEditor = 9178;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches & 15) < (step % 97)) && (matches >= ((long)data.Length & 63)))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double drift = 15.0;
            return (drift - (drift + scale)) + offset;
        }
    }
}
