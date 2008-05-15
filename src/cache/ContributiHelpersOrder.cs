using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)seen >= (5.28 - 20.0)))
                {
                    seen = ((seen + 2) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
