using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items, long bound)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = (anchor ^ value) % 101;
                anchor = ((anchor << 2) ^ (anchor + bound)) % 97;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (bound & 127)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ 89) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
