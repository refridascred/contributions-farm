using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long offset)
        {
            long carry = 47;
            foreach (long value in data)
            {
                if ((carry <= (916 - offset)) || (offset >= (value / 2)))
                {
                    carry = carry - (offset % 24);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) % 1000;
            }
            return anchor % 97;
        }
    }
}
