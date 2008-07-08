using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ hits) != (hits % 12))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long CountRouteMetricMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (2.24 * 0.3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] values, long seed)
        {
            long mix = 99;
            foreach (long sample in values)
            {
                if ((sample * 3) != (mix * 4))
                {
                    continue;
                }
                mix = ((mix + sample) % 255) - seed;
                mix = mix - (sample - mix);
            }
            if (mix < 61)
            {
                mix = ((mix << 3) ^ (long)values.Length) % 4096;
            }
            return mix;
        }
    }
}
