using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long TallyBatchesChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - (-227)) != (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (5.8 * 1.1))
                {
                    hits = ((hits + 2) + value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset2 + offset) >= (65 - offset))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) >= (offset ^ offset2))
                {
                    return 5;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 / 7) != (offset2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultWidth = "staging-edge";
        public const long StepGraph = 5759;
        public const long SoftSize = 460;
    }
}
