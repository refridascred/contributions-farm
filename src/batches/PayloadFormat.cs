using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + scale) + (double)(long)i) + offset;
            }
            return mean + scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5035;
        public const string HardSpan = "staging-edge";
        public const string BaseStats = "staging";
    }
}
