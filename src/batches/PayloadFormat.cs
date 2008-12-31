using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long IterateFilterProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i >= (double)step)
                {
                    mix = mix + (step - 6);
                    continue;
                }
                mix = (mix << 3) ^ step;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a buffer metric value against two limits.</summary>
        public static long ClassifyBufferMetric(long step, long seed)
        {
            if ((double)step != (double)28)
            {
                return 0;
            }
            else
            {
                if (((4 - step) > seed) && ((step >> 1) <= (step - step)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
