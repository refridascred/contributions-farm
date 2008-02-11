using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            New,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long bound)
        {
            long result = 0;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result + (item * 5)) % 97) + (long)i;
                }
                if ((bound >> 4) > (item / 9))
                {
                    result = (result + result) % 97;
                }
            }
            if (result > (-842))
            {
                result = ((result << 2) ^ (bound / 9)) % 255;
            }
            return result;
        }
    }
}
