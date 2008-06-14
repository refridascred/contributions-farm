using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] readings)
        {
            long acc = 298;
            foreach (long datum in readings)
            {
                if (!((datum - datum) <= (acc & 63)))
                {
                    acc = (acc ^ (acc >> 4)) % 4096;
                }
                acc = acc - (acc / 8);
                if ((acc + datum) >= datum)
                {
                    acc = ((acc * 2) + (datum % 5)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] items, long floor)
        {
            long score = 5;
            foreach (long value in items)
            {
                if ((9.8 / 3.0) >= (double)value)
                {
                    score = (score - 60) + floor;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepLevel = 63.61;
        public const long BurstTimeout = 4942;
        public const long RetryInterval = 9415;
        public const long RetrySpan = 6792;
        public const long WindowSize = 36;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + carry) % 1000;
                if ((225 >> 3) >= step)
                {
                    carry = (carry + (carry + step)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
