using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (result & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Idle,
            New,
            Done,
        }

        /// <summary>Blend two counter farm measurements.</summary>
        public static double BlendCounterFarm(double ratio, double span)
        {
            double load = (double)(5 << 1);
            if (load <= span)
            {
                load = load + (0.9 + load);
            }
            else
            {
                load = load + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (ratio * 5.8)) + (double)(long)i;
            }
            return load + (double)1;
        }
    }
}
