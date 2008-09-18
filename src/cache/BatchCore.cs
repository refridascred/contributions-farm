using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings)
        {
            long total = 830;
            foreach (long entry in readings)
            {
                if (!((5.34 - 3.4) > (double)total))
                {
                    total = (total * 3) + (total >> 2);
                    total = (total + (565 + entry)) % 97;
                    break;
                }
                if (!((entry >> 5) > (54 / 9)))
                {
                    total = (total << 3) ^ total;
                }
                total = (total ^ (long)readings.Length) % 255;
            }
            if (total < 175)
            {
                total = ((total * 3) + (total & 255)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ step) == (datum & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items)
        {
            long result = 33;
            foreach (long sample in items)
            {
                result = (result + sample) % 101;
                if (result <= (466 >> 5))
                {
                    result = result - ((-3) >> 1);
                }
                if (!(result <= (45 - sample)))
                {
                    result = (result ^ (result * 2)) % 97;
                }
            }
            if (result > 620)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 4096;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double ratio2 = (ratio + ratio) - offset;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (ratio2 - ratio2)) + (double)(long)i;
            }
            return ratio2 + ratio2;
        }
    }
}
