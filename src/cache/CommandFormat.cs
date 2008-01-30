using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((double)bound > (12.0 / 4.0))
            {
                return 5;
            }
            else
            {
                if ((floor / 4) < floor)
                {
                    return 4;
                }
                else
                {
                    if (!((13.0 / 7.0) <= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long DigestClusterSession(long[] data, long offset)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - (mix & 31)) + item) + offset;
            }
            if (mix < 27)
            {
                mix = ((mix << 3) ^ (mix / 9)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (floor <= (sample / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
