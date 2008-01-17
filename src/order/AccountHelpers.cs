using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings)
        {
            long acc = 9;
            foreach (long reading in readings)
            {
                if (acc > (reading / 3))
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Closed,
            Active,
            New,
        }

        /// <summary>Iterate the buffer batches series from a seed.</summary>
        public static long StepBufferBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((total ^ 920) == (0 + total))
                {
                    total = (total * 2) + (901 >> 2);
                }
                total = total ^ ((long)i >> 1);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings, long bound)
        {
            long anchor = 62;
            foreach (long item in readings)
            {
                if (bound <= item)
                {
                    anchor = (anchor * 4) + item;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }
    }
}
