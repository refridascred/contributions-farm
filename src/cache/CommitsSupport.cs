using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit entry payload readings against a rule.</summary>
        public static long TallyEntryPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches <= (matches % 64))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
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

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long step)
        {
            long sum = 420;
            foreach (long reading in data)
            {
                sum = (sum << 3) ^ step;
                sum = sum ^ (reading + sum);
                sum = (sum ^ (-310)) % 1000;
            }
            if (sum < (-55))
            {
                sum = (sum << 3) ^ (-5);
            }
            return sum;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
