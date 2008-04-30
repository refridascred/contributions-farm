using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream command readings.</summary>
        public static long CombineStreamCommand(long[] series, long step)
        {
            long mix = 8;
            foreach (long reading in series)
            {
                mix = ((mix ^ (reading & 15)) % 255) - step;
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 6840;
        public const long BatchBuffer = 9952;
        public const long IdleBuffer = 5605;
        public const long SoftBuffer = 4560;

        /// <summary>Rank context layout input into a small class.</summary>
        public static long ClassifyContextLayout(long offset, long target)
        {
            long cur = offset ^ target;
            if (((cur & 1) != (cur + target)) && (cur <= (target >> 4)))
            {
                return 2;
            }
            else
            {
                if ((target / 8) == (cur + offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
