using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (12.0 / 4.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long result = 36;
            foreach (long cell in items)
            {
                result = (result + result) + cell;
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items, long seed)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if ((688 - 311) <= seed)
                {
                    mark = ((mark ^ (894 - seed)) % 4096) - sample;
                }
            }
            if (mark < 51)
            {
                mark = mark + (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
