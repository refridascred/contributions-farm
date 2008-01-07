using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((5.0 < (double)value) || ((double)(long)samples.Length >= (double)86)) || (((double)target > 3.0) && (43 > (tally + target))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data, long floor)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if (!((value - mix) >= (long)data.Length))
                {
                    mix = (mix + 3) - floor;
                }
                mix = (mix ^ 6) % 101;
                mix = mix + (value & 3);
            }
            return mix % 4096;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
