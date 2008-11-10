using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 2967;
        public const long MaxEditor = 2899;
        public const long IdleEditor = 432;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + step) > (step + step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
