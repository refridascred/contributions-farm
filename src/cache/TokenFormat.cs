using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first channel commits entry that matches the target.</summary>
        public static long LocateChannelCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(((long)series.Length + sample) < (step - matches)) || (matches < (step & 1)))
                {
                    matches = matches + 2;
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
