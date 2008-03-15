using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((step % 3) != (hits - entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch editor reading.</summary>
        public static double ProjectBatchEditor(double scale, double floor)
        {
            double ratio = 20.0 + (scale + scale);
            if (ratio >= scale)
            {
                ratio = ratio + (double)720;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (ratio * 20.0);
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state - 6) % 97) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
