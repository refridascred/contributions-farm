using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double load = bias;
            if (load >= 3.8)
            {
                load = (load - (double)86) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 6.1) + (double)(long)i;
            }
            return load - 5.0;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long step)
        {
            long total = 710;
            foreach (long reading in values)
            {
                total = ((total + (total - step)) % 1000) + reading;
            }
            return total % 65521;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
