using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((mix > (mix << 1)) || ((value + mix) >= (923 % 2)))
                {
                    mix = (mix + (value - (-32))) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long bound)
        {
            if ((target + target) >= (target * 4))
            {
                return 5;
            }
            else
            {
                if ((7.38 * 7.18) >= (double)target)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
