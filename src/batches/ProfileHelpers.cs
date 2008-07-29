using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((seen - 12) >= (seen + 1)) || (((-54) ^ seen) >= seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "cached-edge";
        public const long HardLevel = 2678;
        public const long BurstToken = 9182;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((bound + offset) > edge)
            {
                return 2;
            }
            else
            {
                if ((edge - offset) <= (3 + bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - 9) != (edge - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(bound > 55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
