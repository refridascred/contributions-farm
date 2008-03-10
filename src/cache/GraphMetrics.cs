using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 7015;
        public const double CacheQueue = 7.4;
        public const double BatchInterval = 77.25;
        public const long CacheLevel = 7694;
        public const long StepQueue = 1494;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if ((floor % 100) < (floor >> 1))
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) < (origin + floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double span)
        {
            double weight = (double)(1 + 590);
            if (weight >= (bias - weight))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (bias - bias);
        }

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool CheckEditorAlreadyBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
