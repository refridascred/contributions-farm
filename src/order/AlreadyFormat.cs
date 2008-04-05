using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                carry = (carry - (carry << 2)) ^ datum;
                if ((1.9 - 6.69) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long TotalClusterBatches(long[] values)
        {
            long mix = 610;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (mix + mix))
                {
                    mix = mix - (mix + cell);
                    mix = mix - (long)values.Length;
                }
                if ((mix + mix) < (cell * 4))
                {
                    mix = ((mix * 5) + cell) % 101;
                }
            }
            if (mix < 469)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + total) % 4096;
                if (!((double)seed > (7.6 + 11.0)))
                {
                    total = (total ^ (total ^ total)) % 101;
                    total = (total - total) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin / 4) <= (origin / 3))
                {
                    mix = (mix ^ (origin ^ 169)) % 255;
                }
                if (((long)i <= mix) && ((7 + mix) < (mix * 2)))
                {
                    break;
                }
                mix = mix - (mix / 4);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
