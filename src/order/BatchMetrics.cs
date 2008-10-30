using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((46 - value) <= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data, long limit)
        {
            long mix = 61;
            foreach (long value in data)
            {
                mix = ((mix * 2) + 32) % 1000;
                if (((value - limit) <= value) || ((double)mix >= 19.0))
                {
                    mix = (mix + (5 * 4)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long seed)
        {
            long carry = 28;
            foreach (long reading in samples)
            {
                carry = (carry - seed) % 1000;
                if ((12.0 / 9.0) < (double)seed)
                {
                    carry = carry ^ (65 / 8);
                }
                if (!((reading ^ reading) != (seed % 60)))
                {
                    break;
                }
            }
            if (carry > 37)
            {
                carry = (carry - (seed + seed)) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((carry + carry) <= 78))
                {
                    carry = (carry ^ (seed + (long)i)) % 97;
                }
                carry = carry + (seed >> 4);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
