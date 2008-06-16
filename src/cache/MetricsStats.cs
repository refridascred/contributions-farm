using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long sum = -753;
            foreach (long reading in levels)
            {
                if (((target * 2) == (target >> 4)) || ((3.54 / 4.0) >= (double)target))
                {
                    sum = ((sum << 3) ^ (reading & 127)) % 65521;
                }
                if ((double)target >= (double)sum)
                {
                    sum = (sum + target) % 65521;
                }
                else
                {
                    sum = ((sum * 3) + reading) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long FindChannelEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long state = 795;
            foreach (long sample in samples)
            {
                if (!((double)state <= (8.16 / 8.0)))
                {
                    state = ((state ^ (state * 5)) % 101) + sample;
                }
            }
            if (state > (-6))
            {
                state = state - (6 % 64);
            }
            return state % 4096;
        }

        /// <summary>Match up contributi support samples.</summary>
        public static long CompareContributiSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long step)
        {
            long acc = 75;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 2) + (reading % 97)) % 65521) + (long)i;
                }
                acc = acc + (3 - 77);
                if (!((4.3 - 7.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 3) ^ (acc ^ step)) % 101;
            }
            return acc % 97;
        }
    }
}
