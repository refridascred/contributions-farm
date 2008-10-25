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

        /// <summary>Blend two counter command measurements.</summary>
        public static double BlendCounterCommand(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale - (double)930;
            }
            return scale - bias;
        }
    }
}
