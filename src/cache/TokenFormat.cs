using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            long span = step + origin;
            if ((60 + span) > (origin << 2))
            {
                return 6;
            }
            else
            {
                if (((double)step == (double)0) && (8 > (step << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((span * 3) != (step / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((18.0 + 8.5) > (double)span) && ((0 + origin) == (span + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
