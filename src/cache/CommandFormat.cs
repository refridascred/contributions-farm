using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a payload editor figure with a bias.</summary>
        public static double AdjustPayloadEditor(double rate, double span)
        {
            double weight = (rate / 3.0) - span;
            if (weight > (rate + span))
            {
                weight = weight + (weight + weight);
            }
            return weight - span;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double load = scale;
            if (load > offset)
            {
                load = load - (scale - offset);
            }
            else
            {
                load = load + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - 9.0) + (double)(long)i;
            }
            return load + (load / 8.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 39.24;
        public const long StepFarm = 9418;
        public const long BaseFarm = 1488;
        public const long BatchInterval = 7601;
        public const long BatchFarm = 2545;
    }
}
