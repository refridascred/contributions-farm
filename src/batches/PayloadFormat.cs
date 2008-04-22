using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long limit)
        {
            long lane = origin + limit;
            if ((double)lane > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((lane & 1) >= (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long SeriesPayloadEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (step < (state + step))
                {
                    state = ((state * 4) + step) % 65521;
                    state = ((state * 3) + 3) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
