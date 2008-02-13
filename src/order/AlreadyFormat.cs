using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Paused,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values, long origin)
        {
            long total = 2;
            foreach (long value in values)
            {
                if (!((origin - value) != (total + value)))
                {
                    total = (total - (value >> 1)) % 4096;
                }
                else
                {
                    total = total ^ (origin * 4);
                }
            }
            return total;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double drift = scale;
            if (drift < (double)329)
            {
                drift = (drift - 5.38) - span;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - drift;
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool GuardSchemaAlreadyRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
