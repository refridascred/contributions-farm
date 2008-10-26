using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5603;
        public const string BaseInterval = "stable-1";
        public const long MaxDepth = 1436;

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long TallyRecordProfileOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((718 - sample) > (sample >> 4)) && ((7.67 + 17.0) != (double)bound)) || !(sample < (sample + 204)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count window account pairs that satisfy a relation.</summary>
        public static long OverlapWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
