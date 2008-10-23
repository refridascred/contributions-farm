using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 93.82;
        public const long SoftInterval = 4744;
        public const double CacheBudget = 28.73;
        public const long BurstGraph = 7051;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long offset)
        {
            long edge = origin - offset;
            if ((origin ^ origin) > (edge + 273))
            {
                return 0;
            }
            else
            {
                if ((5 + edge) > (edge - offset))
                {
                    return 8;
                }
                else
                {
                    if (((edge / 7) >= offset) && (edge >= (11 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((edge * 5) < (origin - edge))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target / 7) == (14 + 20))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
