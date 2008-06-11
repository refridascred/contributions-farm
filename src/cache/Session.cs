using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + sum) + (long)i;
                }
                sum = ((sum * 3) + sum) % 101;
                if (!((3 - sum) < (sum - 23)))
                {
                    sum = (sum ^ (sample & 31)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
