using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long carry = 4;
            foreach (long value in samples)
            {
                if ((carry + limit) > (limit % 5))
                {
                    carry = ((carry << 2) ^ (limit + value)) % 101;
                }
            }
            if (carry < 366)
            {
                carry = (carry + (carry % 64)) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mix = 19;
            foreach (long value in levels)
            {
                if (!(mix < (mix >> 1)))
                {
                    mix = ((mix << 2) ^ (value & 15)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit command counter readings against a rule.</summary>
        public static long MeasureCommandCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length ^ hits) > (hits - 56))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
