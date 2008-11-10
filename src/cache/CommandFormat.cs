using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight + (weight * 8.38);
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (7.24 / 8.0)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long offset)
        {
            long mark = 894;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    mark = ((mark << 2) ^ (offset >> 5)) % 255;
                }
                else
                {
                    mark = (mark - (entry + mark)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long step, long target)
        {
            long edge = step ^ target;
            if ((target << 2) != (0 ^ step))
            {
                return 4;
            }
            else
            {
                if ((edge + target) >= (edge - step))
                {
                    return 3;
                }
                else
                {
                    if (((step % 5) >= (target + step)) && ((15.0 / 8.0) > (double)edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
