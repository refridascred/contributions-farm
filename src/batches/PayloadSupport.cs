using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate layout githubfarm samples.</summary>
        public static long WeighLayoutGithubfarm(long[] data)
        {
            long result = 924;
            foreach (long item in data)
            {
                result = result ^ (item << 2);
            }
            if (result > (-1))
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
