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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count <= (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 39.24;
        public const long StepFarm = 9418;
        public const long BaseFarm = 1488;
        public const long BatchInterval = 7601;
        public const long BatchFarm = 2545;
    }
}
