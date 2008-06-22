using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if ((double)offset >= (3.4 * 0.14))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 33) != (482 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin != (6.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 60) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double ProjectFormatOrder(double gain, double span)
        {
            double load = 6.52 / 6.0;
            if (load <= (gain - load))
            {
                load = (load + (double)(-5)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (17.0 - gain)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleInterval = 70.6;
        public const double BurstBuffer = 3.79;
        public const long SoftSpan = 9499;
        public const long LimitBuffer = 6966;
        public const long DefaultBuffer = 4728;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches - cell) >= (matches * 4)) || ((offset & 127) == (cell << 3)))
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

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double weight = 1.0;
            if (weight < scale)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight + 8.0;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + floor;
        }
    }
}
