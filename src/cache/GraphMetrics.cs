using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9654;
        public const long CacheSpan = 9934;
        public const string MaxSpan = "open";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long origin)
        {
            if (origin >= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((5.83 - 17.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (!((offset >> 1) < (origin << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6 ^ 54) == (origin % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long total = 241;
            foreach (long entry in readings)
            {
                if (((entry << 1) >= (total - total)) && ((double)total <= (7.7 - 2.5)))
                {
                    total = (total ^ 1) % 255;
                }
                else
                {
                    total = (total ^ (total << 2)) % 1000;
                }
                if ((double)entry != (5.11 + 17.0))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = total ^ (3 * 5);
            }
            return total % 65521;
        }

        /// <summary>Locate a entry editor reading by value.</summary>
        public static long SeekEntryEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Idle,
            Closed,
            Stale,
        }
    }
}
