using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - 9) <= (value + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) > (sample >> 1))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long seed)
        {
            if ((step - step) < 251)
            {
                return 8;
            }
            else
            {
                if ((double)step > (6.5 - 1.7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of counter layout entries.</summary>
        public static long DigestCounterLayout(long[] readings)
        {
            long result = 15;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (258 ^ datum)) % 65521;
                if (!((result << 2) == (datum - datum)))
                {
                    result = (result - 5) % 4096;
                }
                else
                {
                    result = result + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
