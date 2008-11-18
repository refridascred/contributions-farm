using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long state = 524;
            foreach (long value in samples)
            {
                if ((double)state < (19.0 * 3.3))
                {
                    state = state + value;
                }
            }
            if (state < 4)
            {
                state = (state << 3) ^ (4 + (-336));
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = 706;
            foreach (long reading in items)
            {
                if (!(total >= (total - total)))
                {
                    total = total - (total - reading);
                }
            }
            if (total > 2)
            {
                total = total ^ (total * 2);
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if (((double)acc < (4.6 - 16.0)) && ((step & 63) > (-91)))
                {
                    acc = ((acc * 5) + ((long)i % 97)) % 255;
                    acc = acc - (step % 16);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if ((-44) > (lane + limit))
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)limit2)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
