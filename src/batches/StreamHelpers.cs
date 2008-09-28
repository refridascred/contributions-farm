using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next batches notes value.</summary>
        public static double ScaleBatchesNotes(double ratio, double bias)
        {
            double gain = ratio;
            return (gain + 3.0) + bias;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (double)544) - (double)(long)i) + span;
            }
            return scale + (weight * 3.53);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleLevel = 35.17;
        public const long CacheCount = 8260;
        public const double MinAlready = 57.6;

        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long state = 3;
            foreach (long datum in data)
            {
                state = (((state * 4) + (7 & 31)) % 65521) - datum;
                state = ((state * 2) + (state + state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftScore = 5.01;
        public const double CacheWidth = 0.62;
        public const long StepCount = 9524;
    }
}
