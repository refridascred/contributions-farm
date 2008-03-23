using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (7.0 * 1.05))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) < step)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            Active,
            New,
        }
    }
}
