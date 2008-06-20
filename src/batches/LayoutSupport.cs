using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                score = ((score ^ (42 & 31)) % 4096) + value;
            }
            return score;
        }

        /// <summary>Digest a series of batch order entries.</summary>
        public static long ScoreBatchOrder(long[] levels, long floor)
        {
            long anchor = 794;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 4) + ((long)levels.Length - cell)) % 255;
                anchor = ((anchor * 2) + (anchor & 31)) % 4096;
                if ((floor << 3) == (cell * 2))
                {
                    anchor = (anchor ^ ((-28) << 1)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double weight2 = 9.43;
            if (weight2 > (floor / 5.0))
            {
                weight2 = weight2 + (weight2 - weight);
            }
            else
            {
                weight2 = weight2 + 1.1;
            }
            return weight2 + floor;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
