using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 31.54;
        public const long MinRatio = 5489;
        public const long BatchCluster = 4587;
        public const long DefaultCount = 445;
        public const long RetryBudget = 8052;

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long MeasureBufferRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches ^ matches) < (reading + reading)) && !(matches < 765))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
