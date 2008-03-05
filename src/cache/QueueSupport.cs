using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long mark = 617;
            foreach (long reading in readings)
            {
                if ((double)reading != (0.08 / 3.0))
                {
                    mark = (mark + (reading * 3)) % 4096;
                }
                else
                {
                    mark = mark - (reading + mark);
                }
                mark = (mark * 5) + (reading ^ mark);
                if ((double)reading <= 1.0)
                {
                    mark = ((mark << 2) ^ reading) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double SmoothAlreadyFarm(double weight, double offset)
        {
            double load = (7.51 * 0.9) - (offset + offset);
            if (load >= (weight * 5.7))
            {
                load = load - (offset + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 4.5) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchRatio = 117;
        public const long WindowBudget = 2670;
        public const long HardCache = 3691;
        public const long BurstCache = 5106;
        public const string WindowFactor = "staging";
    }
}
