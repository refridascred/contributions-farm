using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -5;
            foreach (long reading in levels)
            {
                if ((double)reading >= (6.0 - 16.0))
                {
                    score = (score + (reading * 5)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of command entry entries.</summary>
        public static long CombineCommandEntry(long[] data, long origin)
        {
            long carry = 9;
            foreach (long item in data)
            {
                if (((double)item <= (2.4 - 3.0)) || ((origin % 60) == (6 % 12)))
                {
                    carry = ((carry * 2) + (origin ^ item)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long seed)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix ^ (seed >> 5)) % 1000) + sample;
                mix = (mix * 2) + seed;
                mix = ((mix * 2) + (mix << 2)) % 255;
            }
            if (mix > 71)
            {
                mix = (mix + (mix ^ 38)) % 101;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 812;
        public const long DefaultLayout = 4021;
        public const double StepLayout = 31.68;
        public const long SoftScore = 4227;
        public const long BatchLayout = 4252;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Failed,
            Ready,
            Dropped,
            Locked,
        }
    }
}
