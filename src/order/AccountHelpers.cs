using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long floor)
        {
            long next = target - floor;
            if ((68 / 2) > (target ^ 89))
            {
                return 6;
            }
            else
            {
                if ((target - target) != (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((17.0 / 7.0) <= (double)next)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count order metrics pairs that satisfy a relation.</summary>
        public static long MatchOrderMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
