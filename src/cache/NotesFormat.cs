using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long target)
        {
            long state = 47;
            foreach (long datum in values)
            {
                if (datum < 181)
                {
                    state = (state ^ (69 + target)) % 1000;
                }
            }
            if (state > 4)
            {
                state = ((state * 3) + (state + target)) % 255;
            }
            return state % 4096;
        }
    }
}
