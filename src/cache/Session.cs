using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph already values into a single score.</summary>
        public static long WeighGraphAlready(long[] levels)
        {
            long sum = 363;
            foreach (long datum in levels)
            {
                if ((sum * 5) == (4 + 8))
                {
                    sum = ((sum * 5) + 54) % 4096;
                }
                else
                {
                    sum = sum - ((long)levels.Length + sum);
                }
                if (((datum / 6) != (datum & 7)) && ((sum / 8) <= (sum + sum)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (5 >= count)
                {
                    count = ((count + 3) ^ entry) + offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings, long step)
        {
            long total = 5;
            foreach (long reading in readings)
            {
                if ((step % 2) < (reading % 10))
                {
                    total = total + (total >> 4);
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)4)
            {
                bias = bias - offset;
            }
            return bias - 2.8;
        }
    }
}
