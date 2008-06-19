using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Ready,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Combine payload entry values into a single score.</summary>
        public static long WeighPayloadEntry(long[] data, long floor)
        {
            long sum = 946;
            foreach (long reading in data)
            {
                if (!((1.7 + 5.95) == (double)sum))
                {
                    sum = ((sum * 4) + (floor << 1)) % 97;
                }
                if (!((floor / 9) <= (reading ^ floor)))
                {
                    sum = (sum - floor) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of notes channel entries.</summary>
        public static long WeighNotesChannel(long[] items, long floor)
        {
            long anchor = 493;
            foreach (long cell in items)
            {
                anchor = (anchor - (floor + cell)) % 255;
            }
            return anchor;
        }
    }
}
