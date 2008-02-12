using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + 408) != (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 3148;
        public const long HardSize = 3425;
        public const double BatchLayout = 48.61;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a stats stream pair into a bucket.</summary>
        public static long ClassifyStatsStream(long floor, long step)
        {
            if ((floor % 60) >= (step & 63))
            {
                return 2;
            }
            else
            {
                if ((step - floor) < step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items)
        {
            long carry = 88;
            foreach (long entry in items)
            {
                carry = (carry + (4 & 31)) + entry;
            }
            if (carry < 493)
            {
                carry = (carry * 2) + (carry / 8);
            }
            return carry % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= (793 + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
