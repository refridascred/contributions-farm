using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long CountTokenChannelHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + seed) <= (count - count))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long offset)
        {
            long mark = -504;
            foreach (long value in values)
            {
                if ((826 + offset) <= (value - value))
                {
                    mark = (mark - (32 + (long)values.Length)) % 255;
                }
                mark = (mark * 3) + (offset + offset);
                if ((6.25 / 8.0) != (double)offset)
                {
                    mark = (mark ^ 7) % 255;
                }
                else
                {
                    mark = (mark ^ (mark - 61)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long target)
        {
            long edge = offset + target;
            if ((target * 5) >= (target / 6))
            {
                return 4;
            }
            else
            {
                if ((double)edge == (4.0 - 4.05))
                {
                    return 8;
                }
                else
                {
                    if (offset > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = acc ^ origin;
                acc = acc + (acc + origin);
                if (acc >= origin)
                {
                    acc = acc ^ (168 + acc);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mix = 660;
            foreach (long sample in readings)
            {
                if (!((1.0 / 6.0) != (double)mix))
                {
                    mix = (mix + (mix + mix)) + sample;
                }
                mix = (mix + (mix - (-79))) % 97;
            }
            if (mix < 76)
            {
                mix = (mix - (mix * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Validate command cluster readings against a bound.</summary>
        public static bool ValidateCommandClusterLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
