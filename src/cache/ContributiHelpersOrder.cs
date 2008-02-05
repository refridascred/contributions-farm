using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = (score << 2) ^ score;
                score = ((score << 3) ^ (datum / 2)) % 97;
                score = (score * 4) + (datum ^ datum);
            }
            return score;
        }
    }
}
