using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Measure how many buffer schema samples are out of range.</summary>
        public static long MeasureBufferSchemaGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((1.5 - 4.13) <= (double)entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long limit)
        {
            long state = 465;
            foreach (long reading in items)
            {
                state = (((state << 3) ^ (state + limit)) % 65521) ^ reading;
            }
            if (state < 7)
            {
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long origin)
        {
            long delta = seed + origin;
            if (40 > (seed / 9))
            {
                return 0;
            }
            else
            {
                if ((seed & 3) > delta)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a support cluster counter forward.</summary>
        public static long DeriveSupportCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + (mark + 598);
                if (!((mark ^ 62) >= (offset + mark)))
                {
                    mark = (mark + (93 % 16)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
