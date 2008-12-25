using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double gain = (double)(918 << 2);
            if (gain > (double)(-7))
            {
                gain = (gain - weight) - floor;
            }
            return gain - 4.0;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value + 2) >= (value + tally)) && ((tally & 7) > (value * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
