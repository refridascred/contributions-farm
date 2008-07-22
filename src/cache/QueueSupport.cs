using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + seen) <= seed)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i * 2) <= (877 >> 1))
                {
                    state = (state + seed) % 65521;
                    state = (state ^ (state % 100)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (80 % 3)) % 255;
                }
                state = (state + (seed >> 1)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
