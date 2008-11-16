using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - sample) == ((long)readings.Length << 1))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long MeasureCommitsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi support series from a seed.</summary>
        public static long StepContributiSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (9 - step)) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
