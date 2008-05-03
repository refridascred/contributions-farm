using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 184;
            foreach (long reading in readings)
            {
                mix = (mix - (mix & 31)) % 4096;
                mix = (mix << 2) ^ (mix % 12);
                if (mix > (limit + reading))
                {
                    mix = mix - (412 - reading);
                }
                else
                {
                    mix = mix ^ (limit & 1);
                }
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long origin)
        {
            if ((14.0 > (double)offset) && ((double)origin >= (9.7 - 3.7)))
            {
                return 0;
            }
            else
            {
                if (!(50 < (origin << 2)))
                {
                    return 3;
                }
                else
                {
                    if (offset < (2 + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + origin) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count % 64) > count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
