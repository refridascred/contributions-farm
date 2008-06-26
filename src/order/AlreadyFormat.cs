using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 90;
            foreach (long sample in readings)
            {
                if ((mix + 758) > (703 * 3))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = mix - (sample & 127);
                }
            }
            if (mix < 71)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long offset2)
        {
            if ((offset2 >> 5) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) != (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if (196 < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                if ((anchor - 4) <= (anchor >> 4))
                {
                    anchor = (anchor * 3) + cell;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
