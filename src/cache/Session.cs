using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark / 8)) % 97) + datum) + origin;
            }
            if (mark < 190)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5.8 - 9.4) != (double)seen)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
