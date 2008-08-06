using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double offset)
        {
            double gain = (ratio - offset) + (double)(-69);
            if (gain >= (ratio / 9.0))
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)56) + (double)(long)i;
            }
            return gain + (8.5 + 5.13);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 4586;
        public const long SoftCount = 5131;
        public const long StepProfile = 78;
        public const long StepScore = 1645;
        public const long StepFactor = 1331;

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
