using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if (((datum ^ 595) >= mark) || ((64 % 12) < mark))
                {
                    mark = (mark + (datum >> 1)) % 65521;
                }
                else
                {
                    mark = (mark - datum) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels, long offset)
        {
            long score = -8;
            foreach (long datum in levels)
            {
                score = ((score + offset) % 65521) + datum;
                if ((score / 7) >= (score ^ 83))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score - offset;
            }
            return score;
        }
    }
}
