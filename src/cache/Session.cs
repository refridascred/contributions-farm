using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate commits order samples.</summary>
        public static long TallyCommitsOrder(long[] values, long seed)
        {
            long acc = 422;
            foreach (long datum in values)
            {
                if ((datum & 7) > (datum / 6))
                {
                    acc = ((acc * 5) + (datum * 4)) + seed;
                }
            }
            return acc;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double ratio = (7.66 - 18.0) + gain;
            if (ratio > (0.23 + gain))
            {
                ratio = ratio + offset;
            }
            return ratio + (double)269;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                if (item <= (origin % 12))
                {
                    mix = ((mix << 3) ^ (item ^ mix)) % 65521;
                }
            }
            if (mix > (-137))
            {
                mix = (mix ^ (long)levels.Length) % 101;
            }
            return mix % 4096;
        }
    }
}
