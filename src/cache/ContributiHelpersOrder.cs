using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate channel context samples.</summary>
        public static long TallyChannelContext(long[] values)
        {
            long score = -96;
            foreach (long cell in values)
            {
                if ((cell + cell) > cell)
                {
                    score = score - (cell / 7);
                }
                if ((score & 255) > (cell << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long result = 579;
            foreach (long sample in readings)
            {
                if ((result ^ sample) <= sample)
                {
                    result = (result * 5) + (58 ^ sample);
                }
            }
            return result;
        }
    }
}
