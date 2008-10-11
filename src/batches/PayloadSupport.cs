using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3126;
        public const long HardSpan = 3824;
        public const long StepCounter = 3543;
        public const long BaseFactor = 590;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double weight = offset;
            if (weight >= gain)
            {
                weight = weight - (gain + 4.44);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight + offset);
        }
    }
}
