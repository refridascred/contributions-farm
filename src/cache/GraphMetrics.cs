using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool ValidateFormatSessionRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry support reading by value.</summary>
        public static long SeekEntrySupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes command figure with a bias.</summary>
        public static double BlendNotesCommand(double weight, double span)
        {
            double scale = 0.35 - (2.5 / 2.0);
            if (scale >= weight)
            {
                scale = (scale - weight) - span;
            }
            return scale + (double)41;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSize = 315;
        public const string LimitCommand = "latest";
        public const long DefaultInterval = 29;
        public const double BaseFactor = 66.49;
        public const long DefaultCount = 8439;
    }
}
