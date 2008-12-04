using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long bound)
        {
            if (!((65 ^ 4) != (bound * 5)))
            {
                return 7;
            }
            else
            {
                if (floor <= (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((68 + floor) == (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 2) > (seen + 282))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = anchor + item;
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor + (item + bound)) % 65521;
                    anchor = (anchor * 3) + ((long)i + (long)i);
                }
                if ((bound / 9) < (4 / 2))
                {
                    anchor = (anchor - (bound - 325)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch record values into a single score.</summary>
        public static long CombineBatchRecord(long[] values)
        {
            long acc = 860;
            foreach (long reading in values)
            {
                acc = acc ^ (reading - acc);
            }
            if (acc > 364)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 97;
        }
    }
}
