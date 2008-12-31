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

        /// <summary>Scale a payload buffer figure with a bias.</summary>
        public static double SmoothPayloadBuffer(double weight, double span)
        {
            double load = span;
            if (load > load)
            {
                load = load - (double)654;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (weight + weight)) + (double)(long)i;
            }
            return load + (span / 7.0);
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
