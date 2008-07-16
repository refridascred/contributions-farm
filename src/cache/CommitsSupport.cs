using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long origin)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                carry = (carry - (origin / 6)) + reading;
            }
            if (carry < 9)
            {
                carry = (carry * 4) + (origin - origin);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= 45)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 613;
        public const long IdleNotes = 9830;
        public const long BurstNotes = 2973;
    }
}
