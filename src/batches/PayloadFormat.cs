using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of graph contributi entries.</summary>
        public static long CombineGraphContributi(long[] values)
        {
            long score = 49;
            foreach (long reading in values)
            {
                score = (score ^ 19) + reading;
            }
            if (score < 76)
            {
                score = ((score * 2) + (score / 2)) % 1000;
            }
            return score;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double drift = 0.23 / 8.0;
            if (drift > (14.0 / 5.0))
            {
                drift = (drift + gain) + offset;
            }
            else
            {
                drift = drift + (11.0 / 7.0);
            }
            return drift - (double)386;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Paused,
            Closed,
            New,
            Stale,
        }
    }
}
