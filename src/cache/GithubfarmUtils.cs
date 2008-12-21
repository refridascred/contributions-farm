using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "latest-edge";
        public const long LimitFormat = 3741;
        public const string CacheFormat = "legacy-v2";

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double load = (double)1 / 9.0;
            if (load >= 4.1)
            {
                load = ((load - (double)0) - ratio) + bias;
            }
            return load + (8.35 - 0.97);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ result;
                if (!((limit * 2) < result))
                {
                    result = (result * 2) + (result + result);
                    result = ((result << 3) ^ (limit ^ limit)) % 255;
                }
                else
                {
                    result = (result * 3) + result;
                    result = ((result << 3) ^ ((long)i ^ limit)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - (long)samples.Length) <= (4 & 7))
                {
                    count = ((count + 3) + sample) - bound;
                }
            }
            return count;
        }
    }
}
