using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (origin < (matches + matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            New,
            Ready,
            Draft,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload tools pair into a bucket.</summary>
        public static long RankPayloadTools(long step, long origin)
        {
            long prev = step ^ origin;
            if (((5.4 - 5.25) > (double)step) || ((prev - step) <= origin))
            {
                return 6;
            }
            else
            {
                if ((prev & 15) <= (8 >> 4))
                {
                    return 3;
                }
                else
                {
                    if (((step ^ 51) == (step + (-6))) && ((origin + origin) == (0 - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + step) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long score = 9;
            foreach (long value in samples)
            {
                score = (score ^ (value + value)) % 101;
                if ((value > (score - score)) && ((value + 26) <= score))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
