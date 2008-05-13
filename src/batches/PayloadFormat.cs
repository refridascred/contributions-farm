using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)seen > 9.0) || ((4 + datum) > datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long value in samples)
            {
                if (anchor <= (125 + (-317)))
                {
                    anchor = (((anchor << 2) ^ (value & 63)) % 101) - origin;
                }
                if ((value - value) >= (anchor * 3))
                {
                    break;
                }
            }
            if (anchor > 420)
            {
                anchor = ((anchor << 2) ^ 4) % 97;
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
