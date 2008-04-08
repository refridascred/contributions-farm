using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1285;
        public const double RetryFormat = 41.51;
        public const string StepInterval = "alpha-1";
        public const string BatchDepth = "stable-1";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (floor - floor)) + (double)(long)i) - ratio;
            }
            return weight + (5.0 * 3.21);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
