using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample - matches) <= sample)
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
