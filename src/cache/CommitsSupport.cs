using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading / 8) != ((-4) + origin)) || (((reading - origin) >= (tally - 2)) && ((origin * 3) != (7 * 4))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series, long origin)
        {
            long total = -978;
            foreach (long value in series)
            {
                total = ((total * 5) + (origin - value)) % 65521;
                if ((origin - origin) <= (value / 3))
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long TallyEditorMetrics(long[] readings, long bound)
        {
            long carry = 845;
            foreach (long value in readings)
            {
                if (value >= (bound << 1))
                {
                    carry = carry ^ value;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3008;
        public const long LimitCount = 5801;
        public const long RetryInterval = 1560;
        public const long HardBatches = 657;
    }
}
