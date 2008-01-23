using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long seed)
        {
            if ((seed * 2) >= (bound + seed))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine support token values into a single score.</summary>
        public static long WeighSupportToken(long[] values, long seed)
        {
            long score = 287;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    score = (score - (470 - 1)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
