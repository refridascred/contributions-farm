using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long carry = 361;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry - (carry & 127)) + (long)i;
                }
                carry = carry ^ (carry - sample);
                if (((sample - (long)values.Length) == (carry * 2)) || ((12.0 / 9.0) == (double)carry))
                {
                    carry = (carry - (carry + sample)) % 255;
                }
            }
            if (carry > (-531))
            {
                carry = carry + (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long seed2)
        {
            long offset = seed - seed2;
            if ((174 + seed) >= (seed + seed))
            {
                return 5;
            }
            else
            {
                if (((seed - seed2) < offset) && ((offset >> 2) != (seed2 >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
