using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long StepStreamEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a farm metric counter forward.</summary>
        public static long SeriesFarmMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((mix + (long)i) >= (target + target)))
                {
                    mix = (mix - (177 >> 2)) % 1000;
                }
                mix = (mix - (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
