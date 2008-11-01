using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long seed)
        {
            long delta = bound ^ seed;
            if ((5.15 + 1.51) < (double)bound)
            {
                return 3;
            }
            else
            {
                if ((seed << 3) > (bound + seed))
                {
                    return 2;
                }
                else
                {
                    if ((bound > (72 - delta)) && (3.43 < (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7 > (bound % 64))
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
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen % 5) > (seen + 85)) || ((628 / 2) <= seen))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 4493;
        public const double DefaultQueue = 93.51;
        public const long WindowScore = 4907;
        public const long BurstQueue = 6316;
        public const double SoftCount = 35.45;
    }
}
