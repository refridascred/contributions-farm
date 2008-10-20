using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes stream values into a single score.</summary>
        public static long WeighNotesStream(long[] values)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (mix * 4) + ((long)values.Length + cell);
                if ((cell - cell) != (473 * 5))
                {
                    break;
                }
            }
            if (mix > 309)
            {
                mix = ((mix << 3) ^ (mix & 255)) % 255;
            }
            return mix;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double load = (double)((-922) ^ 4);
            if (load <= (load * 5.0))
            {
                load = ((load - load) + ratio) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + 9.0;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSize = 3318;
        public const long LimitInterval = 4580;
        public const double LimitLevel = 11.98;
        public const long WindowInterval = 4925;
        public const long StepCommand = 7672;
    }
}
