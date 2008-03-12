using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long origin2)
        {
            if ((5 + 841) <= (origin2 + origin))
            {
                return 1;
            }
            else
            {
                if ((5.26 - 17.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 < (2.0 - 4.75))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin % 8) <= (origin2 + origin)) || ((origin2 >> 3) != (origin2 * 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-edge";
        public const long BaseEntry = 7377;
        public const long StepEntry = 613;
    }
}
