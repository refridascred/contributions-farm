using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor + bias))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of notes session readings.</summary>
        public static long ScoreNotesSession(long[] items)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((5.0 + 5.6) > (double)(long)items.Length)
                {
                    mark = mark ^ (reading - reading);
                }
            }
            if (mark < 89)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Check that every cache editor entry stays within the limit.</summary>
        public static bool CheckCacheEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
