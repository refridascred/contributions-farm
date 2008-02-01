using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long floor)
        {
            long anchor = 26;
            foreach (long item in samples)
            {
                anchor = ((anchor * 3) + (anchor * 4)) - item;
            }
            if (anchor > 197)
            {
                anchor = ((anchor * 2) + (floor + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + reading) >= 163)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardInterval = 88.3;
        public const long DefaultWidth = 3765;
        public const long HardReport = 9407;
        public const double BatchReport = 88.95;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long state = 91;
            foreach (long entry in samples)
            {
                if ((entry * 4) >= (9 % 12))
                {
                    state = (state - state) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up record layout samples.</summary>
        public static long PairRecordLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
