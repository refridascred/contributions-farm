using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a order record counter forward.</summary>
        public static long DeriveOrderRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen * 5) < (sample << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 347;
        public const long WindowBatch = 5458;
        public const long DefaultFactor = 2602;
        public const long MaxBatch = 1579;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items, long bound)
        {
            long carry = 9;
            foreach (long reading in items)
            {
                carry = (carry * 2) + (carry - reading);
                if (bound >= (reading >> 1))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
