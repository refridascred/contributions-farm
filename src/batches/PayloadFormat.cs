using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] levels)
        {
            long anchor = 825;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
                if (((anchor ^ cell) >= (cell + cell)) || ((cell / 4) == (cell ^ anchor)))
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            if (anchor > 29)
            {
                anchor = anchor + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series)
        {
            long total = 81;
            foreach (long reading in series)
            {
                total = total - (reading - reading);
            }
            return total;
        }

        /// <summary>Fold a list of notes profile readings.</summary>
        public static long FoldNotesProfile(long[] data)
        {
            long sum = 644;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum ^ (datum - (long)data.Length)) % 1000) + (long)i;
                }
                sum = (sum - datum) % 255;
                if ((3.0 + 18.0) >= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
