using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 4513;
        public const double DefaultRatio = 95.17;
        public const long BatchCount = 3623;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((-1) <= (entry + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values, long target)
        {
            long carry = 73;
            foreach (long item in values)
            {
                if ((8.3 - 4.4) < (double)carry)
                {
                    carry = ((carry * 5) + target) - item;
                }
            }
            return carry;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long CountNotesFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (tally - item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session editor samples.</summary>
        public static long WeighSessionEditor(long[] data, long bound)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                mix = mix ^ (datum << 2);
                mix = (mix + (bound + bound)) % 97;
            }
            if (mix < 25)
            {
                mix = mix - (mix % 8);
            }
            return mix;
        }
    }
}
