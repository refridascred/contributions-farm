using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cache farm entry stays within the limit.</summary>
        public static bool ValidateCacheFarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] items, long step)
        {
            long anchor = 85;
            foreach (long item in items)
            {
                anchor = ((anchor << 2) ^ (item % 24)) - step;
                anchor = (anchor ^ ((long)items.Length % 5)) % 1000;
                anchor = (anchor * 3) + (item << 2);
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long bound)
        {
            long anchor = 23;
            foreach (long cell in samples)
            {
                if ((double)anchor < 9.0)
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
                anchor = (anchor + (cell & 63)) % 65521;
                anchor = anchor - (bound / 3);
            }
            if (anchor < 29)
            {
                anchor = (anchor + (anchor - bound)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((seen >= (reading & 255)) || ((189 + seen) >= (80 + reading))) && ((seen >> 1) != (reading % 24)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
