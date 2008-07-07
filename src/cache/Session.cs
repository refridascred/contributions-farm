using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long offset)
        {
            long lane = seed + offset;
            if ((offset << 1) <= 0)
            {
                return 8;
            }
            else
            {
                if ((((-4) << 2) == (lane + 6)) || ((double)seed <= (6.3 * 4.98)))
                {
                    return 4;
                }
                else
                {
                    if ((lane ^ seed) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long target)
        {
            long next = offset + target;
            if (530 < target)
            {
                return 6;
            }
            else
            {
                if ((5.39 / 6.0) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((622 / 3) >= target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
