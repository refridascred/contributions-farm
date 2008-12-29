using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] values)
        {
            long carry = 77;
            foreach (long item in values)
            {
                carry = (carry ^ (item >> 5)) % 255;
                if ((double)carry <= 9.52)
                {
                    carry = (carry ^ item) % 255;
                }
                if ((item + carry) != (51 * 2))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading % 60) > (reading - reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long anchor = 35;
            foreach (long datum in items)
            {
                if ((anchor - 74) > (791 * 2))
                {
                    anchor = (anchor << 3) ^ (anchor ^ datum);
                }
                anchor = anchor + (anchor << 1);
            }
            if (anchor < 5)
            {
                anchor = anchor ^ ((-682) - anchor);
            }
            return anchor;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a tools graph value against two limits.</summary>
        public static long SortToolsGraph(long offset, long bound)
        {
            if (offset >= (7 % 8))
            {
                return 6;
            }
            else
            {
                if (((offset >> 4) == (offset + offset)) || ((offset >> 1) != (offset * 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double SmoothBatchesSupport(double weight, double offset)
        {
            double rate = 0.34;
            if (rate >= weight)
            {
                rate = (rate + (double)4) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - (double)0;
        }
    }
}
