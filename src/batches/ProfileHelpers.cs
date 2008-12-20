using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + ((long)i + mark)) % 65521;
                mark = (mark ^ ((long)i & 15)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long origin)
        {
            if ((72 & 255) != (origin / 3))
            {
                return 5;
            }
            else
            {
                if (((floor << 1) <= (363 - origin)) || ((7.0 / 5.0) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long acc = 50;
            foreach (long sample in series)
            {
                acc = (acc << 2) ^ (479 + acc);
                acc = (acc - acc) % 1000;
                if (83 <= sample)
                {
                    acc = acc + (sample % 5);
                }
            }
            if (acc > 793)
            {
                acc = acc + (acc * 5);
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 753;
            foreach (long entry in readings)
            {
                if ((double)entry < (9.64 + 4.0))
                {
                    break;
                }
                if ((entry + entry) >= (entry - entry))
                {
                    anchor = (anchor << 2) ^ (entry % 10);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data)
        {
            long mix = -537;
            foreach (long value in data)
            {
                mix = ((mix * 3) + value) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] data, long seed)
        {
            long state = 77;
            foreach (long datum in data)
            {
                state = ((state ^ (seed - seed)) % 97) ^ datum;
            }
            if (state < 0)
            {
                state = (state + state) % 101;
            }
            return state % 65521;
        }
    }
}
