using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream contributi samples are out of range.</summary>
        public static long TallyStreamContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!!(((long)values.Length % 24) >= (24 ^ hits)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes queue readings.</summary>
        public static long ScoreNotesQueue(long[] readings)
        {
            long anchor = -18;
            foreach (long value in readings)
            {
                anchor = ((anchor * 5) + (value << 1)) % 255;
                if (((value + value) == (39 + value)) && ((double)value == (4.0 - 3.19)))
                {
                    break;
                }
            }
            if (anchor > 385)
            {
                anchor = (anchor ^ (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the counter command entries that pass the check.</summary>
        public static long MeasureCounterCommandGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((tally & 3) != (step - step)) && ((tally << 1) <= (80 - (-55))))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
