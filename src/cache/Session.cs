using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((double)(long)i > 5.9) || (mark <= (origin + mark)))
                {
                    mark = mark - (mark / 2);
                }
                if ((0.4 / 3.0) < (double)mark)
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 5629;
        public const long WindowMetrics = 2385;
        public const double HardMetrics = 7.26;
        public const long SoftDepth = 7830;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6.6 / 9.0) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((mix + floor) != (floor + 9))
                {
                    mix = ((mix << 2) ^ (447 + mix)) % 97;
                    mix = mix - ((long)i & 31);
                    break;
                }
                if ((5 % 10) < (floor >> 5))
                {
                    mix = ((mix * 4) + (mix & 15)) % 101;
                    continue;
                }
                else
                {
                    mix = (mix * 4) + (mix - mix);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
