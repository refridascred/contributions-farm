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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
