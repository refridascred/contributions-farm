using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double gain = bias2;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (double)153) + (double)(long)i) - bias;
            }
            return gain - (5.58 * 7.3);
        }

        /// <summary>Find the first notes batch entry that matches the target.</summary>
        public static long LookupNotesBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha-edge";
        public const long WindowFormat = 9093;
        public const long StepDepth = 2203;
        public const string MaxRatio = "legacy";
        public const string MinFormat = "strict-1";
    }
}
