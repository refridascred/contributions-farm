using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue command readings.</summary>
        public static long DigestQueueCommand(long[] data, long origin)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                if ((origin + origin) < mark)
                {
                    mark = ((mark << 2) ^ (origin + 76)) % 1000;
                }
                if (!((cell ^ cell) > (411 & 3)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long bound, long origin)
        {
            if (((double)bound < (3.4 / 2.0)) || ((bound >> 5) < (bound ^ origin)))
            {
                return 3;
            }
            else
            {
                if ((bound % 16) != (origin % 60))
                {
                    return 0;
                }
                else
                {
                    if ((59 << 2) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
