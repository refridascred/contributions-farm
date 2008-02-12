using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long step)
        {
            long result = 673;
            foreach (long item in data)
            {
                result = (result ^ item) % 255;
                if ((step & 127) != (result & 3))
                {
                    result = result + (item ^ result);
                }
            }
            return result;
        }

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long MeasureChannelContextGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 5) != (53 ^ hits)) || (((-287) + hits) <= reading)) || ((4.5 + 12.0) == (double)seed))
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) < (79 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue order readings against a bound.</summary>
        public static bool VerifyQueueOrderBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
