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

        /// <summary>Rank order schema input into a small class.</summary>
        public static long GradeOrderSchema(long offset, long seed)
        {
            long bound = offset - seed;
            if ((6.0 * 3.1) >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (seed >= (bound & 127))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
