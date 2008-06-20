using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ 79) <= (433 >> 3))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset + offset2) <= (offset & 63))
            {
                return 6;
            }
            else
            {
                if (!((offset2 + offset3) < 8))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a context editor figure with a bias.</summary>
        public static double ScaleContextEditor(double ratio, double bias)
        {
            double weight = (double)(709 % 2);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + bias) + (double)(long)i) + ratio;
            }
            return weight + (double)0;
        }
    }
}
