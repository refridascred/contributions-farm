using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double load = scale - (bias - scale);
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            New,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ origin;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
