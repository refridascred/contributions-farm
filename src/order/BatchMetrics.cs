using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (3 % 2)) % 1000;
                sum = ((sum * 2) + (datum >> 3)) % 65521;
            }
            if (sum < 0)
            {
                sum = sum ^ (33 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + (weight2 * 5.91)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (double)598) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 8747;
        public const double WindowSize = 64.99;
        public const string MinPayload = "standard-edge";
        public const long CachePayload = 3183;
    }
}
