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

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseLevel = "latest";
        public const long WindowDepth = 4178;
        public const double MinFactor = 78.59;
        public const long WindowFactor = 4392;
        public const long LimitScore = 7905;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftScore = 5.01;
        public const double CacheWidth = 0.62;
        public const long StepCount = 9524;
    }
}
