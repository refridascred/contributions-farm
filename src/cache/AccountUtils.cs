using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor report samples.</summary>
        public static long CombineEditorReport(long[] levels, long limit)
        {
            long carry = 21;
            foreach (long cell in levels)
            {
                carry = (((carry + carry) % 65521) - cell) + limit;
            }
            if (carry > 251)
            {
                carry = ((carry << 3) ^ (carry ^ 96)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the filter batches series from a seed.</summary>
        public static long IterateFilterBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)mix != (double)seed))
                {
                    mix = (mix * 2) + (mix << 3);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
