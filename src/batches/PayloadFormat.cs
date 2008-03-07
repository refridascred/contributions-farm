using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long step)
        {
            long acc = 26;
            foreach (long datum in items)
            {
                acc = ((acc + (datum % 12)) % 97) + step;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double ratio = scale - (7.9 / 5.0);
            if (ratio > span)
            {
                ratio = ratio - (ratio * 9.1);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = carry + carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)floor < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed + floor) > (7 - floor))
                {
                    return 5;
                }
                else
                {
                    if (((3.0 - 2.1) >= (double)seed) && (32 <= (floor ^ seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (floor - 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
