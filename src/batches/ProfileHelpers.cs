using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the tools schema series from a seed.</summary>
        public static long StepToolsSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = result - (offset ^ offset);
                if (!(offset >= ((long)i + (long)i)))
                {
                    result = (result + (result << 2)) % 1000;
                }
                result = ((result * 5) + (112 % 97)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((anchor >> 3) == (anchor >> 5))
                {
                    anchor = ((anchor * 2) + origin) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data, long step)
        {
            long result = 258;
            foreach (long sample in data)
            {
                result = ((result << 3) ^ (5 + sample)) - step;
                if ((543 ^ 9) >= result)
                {
                    result = (result + (result % 60)) % 65521;
                }
                else
                {
                    result = ((result * 2) + (sample & 63)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Failed,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
