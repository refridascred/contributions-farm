using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine payload notes values into a single score.</summary>
        public static long ScorePayloadNotes(long[] items, long step)
        {
            long score = -96;
            foreach (long sample in items)
            {
                if (sample > (sample * 3))
                {
                    score = (score + ((long)items.Length ^ step)) % 101;
                    break;
                }
                else
                {
                    score = ((score * 4) + (321 + 4)) % 65521;
                }
                if (((7 & 63) < (score * 4)) || ((double)step != (double)sample))
                {
                    score = (score << 2) ^ (-523);
                }
            }
            if (score < 995)
            {
                score = (score ^ (9 - (long)items.Length)) % 255;
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Failed,
            Stale,
            Retry,
            Draft,
        }

        /// <summary>Look up the position of a counter already sample.</summary>
        public static long LocateCounterAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
