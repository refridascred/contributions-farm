using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long FoldRecordBuffer(long[] readings, long floor)
        {
            long total = 269;
            foreach (long cell in readings)
            {
                total = ((total ^ (total % 10)) % 65521) - floor;
                if (total > (cell % 5))
                {
                    total = (total + (cell << 2)) % 97;
                }
                if ((total > (total >> 5)) && ((4 / 7) >= (total * 2)))
                {
                    break;
                }
            }
            if (total > 55)
            {
                total = ((total * 5) + 2) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 289;
            foreach (long value in data)
            {
                if ((value >> 3) < carry)
                {
                    carry = ((carry << 3) ^ (carry - 12)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((offset & 63) < matches) || ((double)6 == (double)matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
