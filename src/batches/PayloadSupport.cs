using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor commits reading by value.</summary>
        public static long LocateEditorCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (acc / 4)) - value;
            }
            if (acc < 80)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double rate = 13.0;
            return ((rate - (double)2) + gain) + floor;
        }
    }
}
