using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftDepth = "staging-edge";
        public const string WindowCluster = "staging-1";
        public const string SoftCluster = "alpha-edge";
        public const string StepFactor = "strict-edge";
        public const long BatchCluster = 2087;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long acc = 24;
            foreach (long cell in items)
            {
                if ((bound <= (bound >> 3)) || ((double)bound > (2.6 + 8.39)))
                {
                    acc = (acc + (cell + acc)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
