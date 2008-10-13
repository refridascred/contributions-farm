using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long CountAlreadyStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count % 64) < 576)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = score - ((long)i << 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (20 > delta)
            {
                return 8;
            }
            else
            {
                if (((9.9 + 1.3) < (double)delta) && ((double)floor2 != (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long bound)
        {
            long anchor = 61;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor * 2) + reading) % 65521) + (long)i;
                    anchor = (anchor ^ (201 + bound)) % 4096;
                }
                if ((reading ^ anchor) < anchor)
                {
                    anchor = anchor + reading;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor + (bound % 2);
            }
            return anchor % 1000;
        }
    }
}
