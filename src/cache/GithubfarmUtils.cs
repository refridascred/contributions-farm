using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (floor >> 2)) % 1000;
                if (mix < ((-3) & 7))
                {
                    mix = mix + (mix * 5);
                }
                else
                {
                    mix = (mix * 2) + mix;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinRatio = 76;
        public const long IdleTimeout = 1040;
        public const string IdleDepth = "strict-edge";
        public const double MinBuffer = 22.62;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)target == (4.82 - 2.4))
                {
                    result = (result + (target / 7)) % 255;
                    result = (result ^ ((long)i % 10)) % 65521;
                }
                result = (result + result) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
