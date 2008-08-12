using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (target > matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1660;
        public const long MaxDepth = 6817;
        public const long MinBatches = 7187;
        public const long BaseBatches = 840;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            long cur = step ^ bound;
            if (((bound + cur) == (cur - cur)) || ((double)step == (9.78 - 1.0)))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (4.7 * 9.63))
                {
                    return 5;
                }
                else
                {
                    if ((cur / 9) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (mix % 100)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
