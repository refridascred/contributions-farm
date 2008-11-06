using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4935;
        public const string MaxCommits = "stable-1";
        public const double BurstCommits = 57.48;
        public const long SoftCommits = 8736;
        public const string DefaultCommits = "alpha-edge";

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings)
        {
            long mark = 105;
            foreach (long datum in readings)
            {
                if ((78 - mark) >= mark)
                {
                    mark = (mark << 2) ^ (datum & 7);
                }
                else
                {
                    mark = (mark ^ (916 * 5)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit already context readings against a rule.</summary>
        public static long MeasureAlreadyContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally > (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
