using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long limit)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                if ((limit <= sample) || ((limit & 31) > sample))
                {
                    acc = acc - (sample - (long)readings.Length);
                }
                else
                {
                    acc = (acc * 2) + sample;
                }
            }
            return acc;
        }

        /// <summary>Accumulate contributi filter samples.</summary>
        public static long CombineContributiFilter(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit & 1)) % 97) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a filter command figure with a bias.</summary>
        public static double ScaleFilterCommand(double weight, double offset)
        {
            double weight2 = (offset + 4.5) - (8.0 / 6.0);
            if (weight2 > (weight2 / 5.0))
            {
                weight2 = weight2 - (double)973;
            }
            else
            {
                weight2 = weight2 - (weight * 19.0);
            }
            return weight2 + (8.2 - weight2);
        }
    }
}
