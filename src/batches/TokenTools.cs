using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long origin)
        {
            if ((20.0 >= (double)origin) && ((3 + 1) >= origin))
            {
                return 4;
            }
            else
            {
                if ((step ^ 440) >= (step + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > (2.4 - 5.47))
                    {
                        return 2;
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
