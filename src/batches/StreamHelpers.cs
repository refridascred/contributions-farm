using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((limit <= entry) && ((-62) > (entry + carry)))
                {
                    carry = (carry + (limit - entry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((6.17 / 4.0) < (double)tally) || (item > (20 + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc << 3) ^ seed;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (3.74 < (double)target)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
