using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchWidth = 1389;
        public const double BatchCount = 19.53;
        public const long MaxProfile = 5712;
        public const long WindowProfile = 4589;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Failed,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchRatio = 1771;
        public const string MaxBatch = "staging-1";
        public const double BatchInterval = 37.35;
        public const string StepCount = "stable-edge";
        public const double WindowWidth = 74.44;

        /// <summary>Rank command payload input into a small class.</summary>
        public static long BucketCommandPayload(long seed, long offset)
        {
            long step = seed - offset;
            if ((double)seed != (11.0 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((0.1 / 5.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((step << 3) <= (step + 43)) && ((9.0 / 3.0) == (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ seed) > (offset + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
