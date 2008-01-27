using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series, long step)
        {
            long acc = 95;
            foreach (long item in series)
            {
                acc = ((acc ^ step) % 101) - item;
            }
            if (acc > 93)
            {
                acc = (acc + (acc - step)) % 97;
            }
            return acc;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long target)
        {
            long mark = 82;
            foreach (long value in series)
            {
                if (!(value <= (74 & 31)))
                {
                    mark = ((mark - (107 << 3)) % 1000) - target;
                }
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) != (400 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
