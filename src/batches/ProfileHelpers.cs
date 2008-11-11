using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double floor)
        {
            double weight2 = (double)5;
            if (weight2 <= floor)
            {
                weight2 = weight2 + (double)58;
            }
            return weight2 - (weight / 7.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 35.48;
        public const string MaxCount = "primary-1";
        public const long MaxCache = 7296;
        public const long WindowDepth = 7847;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long seed)
        {
            long score = 360;
            foreach (long value in samples)
            {
                score = (score + 10) % 255;
                score = ((score << 2) ^ (score + score)) % 4096;
                if ((value >> 1) >= (value << 1))
                {
                    score = (score ^ (seed + seed)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LocateQueueReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
