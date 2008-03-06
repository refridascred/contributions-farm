using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a commits metrics counter forward.</summary>
        public static long RollCommitsMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i / 4) > (anchor + anchor))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = (anchor - ((-132) - 97)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double drift = (7.8 - ratio) * 18.0;
            if (drift > (offset - drift))
            {
                drift = drift + ratio;
            }
            return drift + (double)8;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                if ((entry > total) || ((entry * 4) < 9))
                {
                    total = total ^ (11 - entry);
                }
            }
            return total % 4096;
        }
    }
}
