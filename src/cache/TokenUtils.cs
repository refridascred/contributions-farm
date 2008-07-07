using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 4.0) + (double)(long)i) - offset;
            }
            return scale + (double)1;
        }

        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool GuardBatchesNotesRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
