using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double weight = scale / 7.0;
            if (weight <= (3.0 / 7.0))
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - 5.62;
        }

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long ScoreContributiBatch(long[] items)
        {
            long result = 108;
            foreach (long datum in items)
            {
                if ((2.92 / 9.0) > (double)result)
                {
                    result = (result + result) + datum;
                }
                else
                {
                    result = (result + 21) % 255;
                }
            }
            return result;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = total - ((long)i - limit);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Failed,
            Stale,
        }
    }
}
