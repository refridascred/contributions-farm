using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double weight, double floor)
        {
            double gain = (double)((-3) / 9);
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - 2.22) + (double)(long)i) + floor;
            }
            return gain - (weight / 7.0);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + count) > (count ^ count))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
