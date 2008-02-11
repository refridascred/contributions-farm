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

        /// <summary>Fold a list of schema token readings.</summary>
        public static long ScoreSchemaToken(long[] values)
        {
            long sum = -47;
            foreach (long reading in values)
            {
                if ((reading / 9) == (sum + sum))
                {
                    sum = (sum ^ (reading + 8)) % 255;
                }
            }
            if (sum > 246)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
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
