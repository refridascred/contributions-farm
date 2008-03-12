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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-edge";
        public const long BaseEntry = 7377;
        public const long StepEntry = 613;
    }
}
