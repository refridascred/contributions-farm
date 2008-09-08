using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 6302;
        public const long HardRatio = 351;
        public const long StepInterval = 9600;
        public const string RetryReport = "latest-edge";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if (((long)levels.Length != (datum - carry)) || ((carry << 1) >= (datum & 1)))
                {
                    carry = (carry + datum) % 4096;
                }
                else
                {
                    carry = carry + (78 - datum);
                }
                if (((carry % 64) <= carry) || ((datum - carry) >= ((-1) + carry)))
                {
                    carry = (carry * 2) + (carry - (-39));
                }
            }
            if (carry > 86)
            {
                carry = carry - (carry << 2);
            }
            return carry;
        }
    }
}
