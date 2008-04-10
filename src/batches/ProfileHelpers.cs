using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                if (cell < mark)
                {
                    mark = ((mark * 3) + (cell - cell)) % 255;
                }
            }
            if (mark < (-917))
            {
                mark = mark + (mark % 3);
            }
            return mark;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long origin)
        {
            long sum = -5;
            foreach (long value in data)
            {
                if (!((907 << 2) >= value))
                {
                    sum = ((sum * 5) + (8 - value)) % 255;
                }
                if (!((13.0 - 3.4) < (double)origin))
                {
                    sum = (sum << 2) ^ (value >> 1);
                }
                else
                {
                    sum = (sum - (sum >> 3)) % 255;
                    sum = sum - (sum & 255);
                }
                if ((59 / 5) < (value + origin))
                {
                    sum = ((sum << 2) ^ (origin / 3)) % 255;
                }
                else
                {
                    sum = sum - value;
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count * 5) < (9 - value)) || (((605 ^ count) <= ((-427) + count)) && ((double)37 > (double)(long)series.Length)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 3) > (seen - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
