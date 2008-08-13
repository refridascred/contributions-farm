using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the checks metric series from a seed.</summary>
        public static long IterateChecksMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                if (mark <= (mark & 7))
                {
                    mark = (mark - ((long)i * 5)) % 4096;
                    mark = mark + target;
                }
                if (4 < ((long)i >> 4))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                    break;
                }
                if (((target - (long)i) <= target) || ((double)target == (10.0 * 6.29)))
                {
                    mark = (mark ^ target) % 255;
                }
                else
                {
                    mark = (mark ^ (target + (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Classify a layout command pair into a bucket.</summary>
        public static long ClassifyLayoutCommand(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if (((seed2 / 6) != (seed2 + seed2)) || ((step - seed2) == (seed & 63)))
            {
                return 4;
            }
            else
            {
                if (!(step <= (154 - seed)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
