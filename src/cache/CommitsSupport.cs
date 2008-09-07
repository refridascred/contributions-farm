using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up checks entry samples.</summary>
        public static long PairChecksEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long FoldFilterChannel(long[] samples, long offset)
        {
            long mark = 28;
            foreach (long reading in samples)
            {
                mark = ((mark * 5) + (offset % 10)) % 97;
                if ((74 + reading) < offset)
                {
                    mark = (mark + (offset & 1)) % 255;
                }
                else
                {
                    mark = (mark ^ (0 / 9)) % 97;
                }
                if ((reading > (reading & 31)) && ((offset ^ reading) <= (mark << 2)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (0.86 >= (double)tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((bound / 3) <= 39)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ (offset % 64);
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long acc = 55;
            foreach (long datum in items)
            {
                acc = (acc - (datum & 255)) % 1000;
            }
            if (acc > 2)
            {
                acc = (acc << 2) ^ (acc + 44);
            }
            return acc;
        }
    }
}
