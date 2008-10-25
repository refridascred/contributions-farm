using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mark = 89;
            foreach (long cell in values)
            {
                if (((mark / 6) <= (cell % 100)) && ((3.65 / 9.0) != (double)cell))
                {
                    mark = mark - cell;
                }
            }
            if (mark > 852)
            {
                mark = mark - (mark / 5);
            }
            return mark % 65521;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long mix = 44;
            foreach (long cell in series)
            {
                mix = (mix + (cell + cell)) - step;
                mix = (mix + (0 / 6)) % 255;
            }
            return mix % 4096;
        }
    }
}
