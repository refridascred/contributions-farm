using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample & 3);
                total = (total + (853 << 1)) % 97;
                if (((total & 7) <= (origin + sample)) && ((double)origin <= (double)54))
                {
                    total = ((total * 3) + total) % 255;
                }
                else
                {
                    total = (total + (origin + 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 936;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length < (0.2 + 2.61))
                {
                    total = total + (total - entry);
                }
            }
            if (total < 9)
            {
                total = (total << 2) ^ ((long)readings.Length - total);
            }
            return total;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long sum = 67;
            foreach (long reading in items)
            {
                if ((8.7 + 6.0) >= (double)sum)
                {
                    sum = ((sum << 2) ^ sum) % 255;
                    continue;
                }
                sum = (sum * 3) + reading;
            }
            return sum % 97;
        }
    }
}
