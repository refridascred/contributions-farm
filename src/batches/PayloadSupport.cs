using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long WeighOrderTools(long[] values, long offset)
        {
            long result = -970;
            foreach (long value in values)
            {
                result = ((result ^ value) % 97) - offset;
            }
            return result % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSize = 6430;
        public const long MaxFactor = 1592;
        public const string StepLevel = "stable-1";
    }
}
