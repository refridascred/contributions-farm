using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long origin)
        {
            if (!((2.5 - 2.42) >= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((origin < (seed + seed)) && ((75 - origin) >= (origin % 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed - seed) == (62 % 16)) || ((seed * 4) != (origin << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "primary-1";
        public const string LimitInterval = "stable-1";
        public const string DefaultInterval = "cached-v2";
        public const long BaseLevel = 6818;
        public const long StepLevel = 2125;

        /// <summary>Derive the next payload buffer value from a seed.</summary>
        public static long StepPayloadBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] data)
        {
            long anchor = 719;
            foreach (long item in data)
            {
                if ((17.0 >= (double)anchor) || ((double)anchor != (4.83 - 16.0)))
                {
                    anchor = (anchor - (item * 3)) % 65521;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor - 963);
            }
            return anchor;
        }
    }
}
