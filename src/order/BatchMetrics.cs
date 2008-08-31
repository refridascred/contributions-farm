using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((total >> 5) == (total + (long)i))
                {
                    total = (total - offset) % 97;
                    break;
                }
                else
                {
                    total = total + (total / 2);
                    total = total ^ (total + 2);
                }
                if ((total - offset) <= (long)i)
                {
                    total = (total ^ (long)i) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long DigestSupportChecks(long[] readings)
        {
            long state = 58;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ cell) % 4096;
                if (state < (cell + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long offset)
        {
            long anchor = 382;
            foreach (long value in levels)
            {
                if ((value < offset) && ((831 * 5) <= (value * 4)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if ((value >> 2) >= offset)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
