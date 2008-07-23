using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor >> 3) <= (tally >> 4))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 492;
        public const double MaxRecord = 51.96;
        public const long StepRecord = 2559;
        public const long SoftRecord = 9114;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ ((long)i + 20)) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
