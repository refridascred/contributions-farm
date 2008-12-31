using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 97) > target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a editor batches counter forward.</summary>
        public static long DeriveEditorBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
