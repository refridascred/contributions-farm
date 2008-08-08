using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardLevel = 9708;
        public const double HardRecord = 83.08;
        public const long WindowScore = 1117;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = ((acc - (acc * 4)) % 1000) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long mark = 47;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)mark)
                {
                    mark = (mark + (reading ^ mark)) % 101;
                }
                if ((double)reading < 8.15)
                {
                    mark = (mark - (mark - mark)) % 4096;
                }
                mark = ((mark << 2) ^ (mark >> 5)) % 97;
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit + tally) <= (limit * 3))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
