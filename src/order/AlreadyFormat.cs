using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((48 ^ origin) == (origin >> 2))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 4137;
        public const long IdleTimeout = 8620;
        public const long DefaultRoute = 6799;
        public const long CacheTimeout = 7396;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
