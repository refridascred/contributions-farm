using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 2) <= (cell + tally)) && ((cell + 3) >= (cell % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if ((acc >> 4) < (951 - acc))
                {
                    acc = (acc - (value - limit)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data)
        {
            long sum = -12;
            foreach (long value in data)
            {
                if (((long)data.Length > (value + value)) || ((sum - sum) >= value))
                {
                    sum = sum - (sum + value);
                }
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) != ((long)readings.Length ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 6644;
        public const long WindowCommand = 4855;
        public const long DefaultSpan = 1891;
    }
}
