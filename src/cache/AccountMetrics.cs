using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up cache editor samples.</summary>
        public static long MatchCacheEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i & 255) <= (origin * 2)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                if (origin <= acc)
                {
                    acc = (acc + (origin + acc)) % 65521;
                    acc = acc - (origin - origin);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum % 5) <= (datum + hits)) || ((hits - hits) > (datum * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data)
        {
            long result = 30;
            foreach (long value in data)
            {
                if ((double)result >= 6.0)
                {
                    result = ((result * 4) + ((-607) & 127)) - value;
                }
            }
            if (result > 67)
            {
                result = ((result << 3) ^ result) % 1000;
            }
            return result;
        }
    }
}
