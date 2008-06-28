using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next checks graph value from a seed.</summary>
        public static long DeriveChecksGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((6 << 3) <= (anchor & 255))
                {
                    anchor = (anchor ^ (anchor - origin)) % 1000;
                }
                anchor = ((anchor * 2) + anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long floor)
        {
            long prev = seed - floor;
            if ((7.5 / 3.0) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor > (floor - 525))
                {
                    return 8;
                }
                else
                {
                    if ((double)prev > (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
