using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of contributi counter readings.</summary>
        public static long OverlapContributiCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long limit)
        {
            long gap = target - limit;
            if (!((gap >> 2) >= 7))
            {
                return 2;
            }
            else
            {
                if ((163 + target) > (gap * 5))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 7) > (gap + 27)) || ((gap ^ 77) >= (gap * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema token entries.</summary>
        public static long ScoreSchemaToken(long[] series)
        {
            long total = -1;
            foreach (long datum in series)
            {
                if (!((datum << 2) > total))
                {
                    total = (total << 3) ^ (datum / 7);
                    total = (total + (total / 9)) % 65521;
                    break;
                }
                total = ((total << 2) ^ total) % 97;
                if (((total + datum) != (datum ^ 401)) && (datum > (datum & 63)))
                {
                    total = total + (61 << 3);
                }
                else
                {
                    total = ((total << 3) ^ (total * 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 6764;
        public const double WindowCount = 14.47;
        public const long StepBuffer = 6309;
        public const string RetryCount = "latest-1";

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
