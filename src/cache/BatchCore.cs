using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally != (7.6 / 8.0))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (seed * 5)) % 255) ^ (long)i2;
                }
                state = ((state << 2) ^ (state & 15)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long acc = 973;
            foreach (long datum in data)
            {
                if ((acc & 31) != (datum / 4))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 101;
                }
                else
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 99)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
