using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double gain, double offset)
        {
            double bias = 0.08;
            if (bias > bias)
            {
                bias = bias + (offset + offset);
            }
            return bias - (4.5 - gain);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support stream readings.</summary>
        public static long PairSupportStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (0.36 > (double)count)
                {
                    count = ((count + 3) ^ reading) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
